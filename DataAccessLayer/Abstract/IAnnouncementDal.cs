using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IAnnouncementDal : IGenericDal<Announcement>
    {
        void ChangeStatusToTrue(int id);
        void ChangeStatusToFalse(int id);
    }
}
