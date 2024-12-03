using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfAnnouncementDal : GenericRepository<Announcement>, IAnnouncementDal
    {
        public void ChangeStatusToFalse(int id)
        {
            using var context = new AgricultureContext();
            Announcement announcement = context.Announcements.Find(id);
            announcement.Status = false;
            context.SaveChanges();
        }

        public void ChangeStatusToTrue(int id)
        {
            using var context = new AgricultureContext();
            Announcement announcement = context.Announcements.Find(id);
            announcement.Status = true;
            context.SaveChanges();
        }
    }
}
