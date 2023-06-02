using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class AnnouncementManager : IAnnouncementService
{
    private readonly IAnnouncementDal _announcementDal;

    public AnnouncementManager(IAnnouncementDal announcementDal)
    {
        _announcementDal = announcementDal;
    }

    public void TAdd(Announcement entity)
    {
        _announcementDal.Insert(entity);
    }

    public void TDelete(Announcement entity)
    {
        _announcementDal.Delete(entity);
    }

    public void TUpdate(Announcement entity)
    {
        _announcementDal.Update(entity);
    }

    public List<Announcement> TGetList()
    {
        return _announcementDal.GetList();
    }

    public Announcement TGetByID(int id)
    {
        return _announcementDal.GetByID(id);
    }
}