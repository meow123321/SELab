using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEClassroom.DataAccess;
using SEClassroom.AppLogic.Abstractions;
using SEClassroom.AppLogic.Data;

namespace SEClassroom.Models
{
    public class SQLAnnouncementRepository : IAnnouncementRepository
    {
        private readonly SEClassroomDBContext context;

        public SQLAnnouncementRepository(SEClassroomDBContext context)
        {
            this.context = context;
        }

        public Announcement Add(Announcement announcement)
        {
            context.Announcements.Add(announcement);
            context.SaveChanges();
            return announcement;
        }

        public Announcement Delete(Guid Id)
        {
            Announcement announcement = context.Announcements.Find(Id);
            if (announcement != null)
            {
                context.Announcements.Remove(announcement);
                context.SaveChanges();
            }
            return announcement;
        }

        public Announcement GetAnnouncement(Guid Id)
        {
            return context.Announcements.Find(Id);
        }

        public IEnumerable<Announcement> GetAnnouncements()
        {
            return context.Announcements;
        }

        public Announcement Update(Announcement announcementChanges)
        {
            var announcement = context.Announcements.Attach(announcementChanges);
            announcement.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return announcementChanges;
        }
    }
}
