using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class AppUserManager : IAppUserService
{
    private IAppUserDal _appUserDal;

    public AppUserManager(IAppUserDal appUserDal)
    {
        _appUserDal = appUserDal;
    }

    public void TAdd(AppUser entity)
    {
        _appUserDal.Insert(entity);
    }

    public void TDelete(AppUser entity)
    {
        _appUserDal.Delete(entity);
    }

    public void TUpdate(AppUser entity)
    {
        _appUserDal.Update(entity);
    }

    public List<AppUser> TGetList()
    {
        return _appUserDal.GetList();
    }

    public AppUser TGetByID(int id)
    {
       return _appUserDal.GetByID(id);
    }
}