using GGTech.Infrastructure.Enum;
using System;

namespace GGTech.Application.ViewModel.System
{
    public class AnnouncementViewModel
    {
        public string Id { get; set; }

        public string Title { set; get; }

        public string Content { set; get; }

        public Guid UserId { set; get; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public Status Status { set; get; }
    }
}