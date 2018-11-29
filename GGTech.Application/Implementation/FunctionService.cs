using AutoMapper;
using AutoMapper.QueryableExtensions;
using GGTech.Application.Interface;
using GGTech.Application.ViewModel.System;
using GGTech.Domain.Data.Entity;
using GGTech.Infrastructure.Enum;
using GGTech.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GGTech.Application.Implementation
{
    public class FunctionService : IFunctionService
    {
        private IRepository<Function, string> _functionRepository;
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FunctionService(IMapper mapper,
            IRepository<Function, string> functionRepository,
            IUnitOfWork unitOfWork)
        {
            _functionRepository = functionRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public bool CheckExistedId(string id)
        {
            return _functionRepository.SelectById(id) != null;
        }

        public void Add(FunctionViewModel functionVm)
        {
            var function = _mapper.Map<Function>(functionVm);
            _functionRepository.Insert(function);
        }

        public void Delete(string id)
        {
            _functionRepository.Delete(id);
        }

        public FunctionViewModel GetById(string id)
        {
            var function = _functionRepository.SelectSingle(x => x.Id == id);
            return Mapper.Map<Function, FunctionViewModel>(function);
        }

        public Task<List<FunctionViewModel>> GetAll(string filter)
        {
            var query = _functionRepository.SelectAll(x => x.Status == Status.Active);
            if (!string.IsNullOrEmpty(filter))
                query = query.Where(x => x.Name.Contains(filter));
            return query.OrderBy(x => x.ParentId).ProjectTo<FunctionViewModel>().ToListAsync();
        }

        public IEnumerable<FunctionViewModel> GetAllWithParentId(string parentId)
        {
            return _functionRepository.SelectAll(x => x.ParentId == parentId).ProjectTo<FunctionViewModel>();
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(FunctionViewModel functionVm)
        {
            var functionDb = _functionRepository.SelectById(functionVm.Id);
            var function = _mapper.Map<Function>(functionVm);
        }

        public void ReOrder(string sourceId, string targetId)
        {
            var source = _functionRepository.SelectById(sourceId);
            var target = _functionRepository.SelectById(targetId);
            int tempOrder = source.SortOrder;

            source.SortOrder = target.SortOrder;
            target.SortOrder = tempOrder;

            _functionRepository.Update(source);
            _functionRepository.Update(target);
        }

        public void UpdateParentId(string sourceId, string targetId, Dictionary<string, int> items)
        {
            //Update parent id for source
            var category = _functionRepository.SelectById(sourceId);
            category.ParentId = targetId;
            _functionRepository.Update(category);

            //Get all sibling
            var sibling = _functionRepository.SelectAll(x => items.ContainsKey(x.Id));
            foreach (var child in sibling)
            {
                child.SortOrder = items[child.Id];
                _functionRepository.Update(child);
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}