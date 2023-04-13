using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class AboutManager : IAboutService
{
    IAboutDal _aboutDal;

    public AboutManager(IAboutDal aboutDal)
    {
        _aboutDal = aboutDal;
    }
    public void TAdd(About entity)
    {
        _aboutDal.Insert(entity);
    }

    public void TDelete(About entity)
    {
        _aboutDal.Delete(entity);
    }

    public void TUpdate(About entity)
    {
        _aboutDal.Update(entity);
    }

    public List<About> TGetList()
    {
        return _aboutDal.GetList();
    }

    public About TGetByID(int id)
    {
        throw new NotImplementedException();
    }
}