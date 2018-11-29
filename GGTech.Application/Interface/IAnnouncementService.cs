using GGTech.Application.ViewModel.System;
using GGTech.Commons.AppDto;
using System;

namespace GGTech.Application.Interface
{
    public interface IAnnouncementService
    {
        PagedResult<AnnouncementViewModel> GetAllUnReadPaging(Guid userId, int pageIndex, int pageSize);

        bool MarkAsRead(Guid userId, string id);
    }
}