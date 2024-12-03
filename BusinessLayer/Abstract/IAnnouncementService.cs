using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IAnnouncementService : IGenericService<Announcement>
    {
        void ChangeStatusToTrue(int id);
        void ChangeStatusToFalse(int id);
    }
}
