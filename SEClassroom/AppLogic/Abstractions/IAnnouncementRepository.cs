using System;
using System.Collections.Generic;
using System.Text;
using SEClassroom.AppLogic.Data;

namespace SEClassroom.AppLogic.Abstractions
{
    public interface IAnnouncementRepository: IRepository<Announcement>
    {
        Announcement GetAnnouncement(Guid Id);
        IEnumerable<Announcement> GetAnnouncements();
        Announcement Add(Announcement announcement);
        Announcement Update(Announcement announcementChanges);
        Announcement Delete(Guid Id);
    }
}
