using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;
        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void Add(Announcement entity)
        {
            _announcementDal.Add(entity);
        }

        public void ChangeStatusToFalse(int id)
        {
            _announcementDal.ChangeStatusToFalse(id);
        }

        public void ChangeStatusToTrue(int id)
        {
            _announcementDal.ChangeStatusToTrue(id);
        }

        public void Delete(Announcement entity)
        {
            _announcementDal.Delete(entity);
        }

        public Announcement GetById(int id)
        {
            return _announcementDal.GetById(id);
        }

        public List<Announcement> GetListAll()
        {
            return _announcementDal.GetListAll();
        }

        public void Update(Announcement entity)
        {
            _announcementDal.Update(entity);
        }
    }
}
