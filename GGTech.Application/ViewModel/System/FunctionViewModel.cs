using GGTech.Infrastructure.Enum;

namespace GGTech.Application.ViewModel.System
{
    public class FunctionViewModel
    {
        public string Id { get; set; }

        public string Name { set; get; }

        public string URL { set; get; }

        public string ParentId { set; get; }

        public string IconCss { get; set; }
        public int SortOrder { set; get; }
        public Status Status { set; get; }
    }
}