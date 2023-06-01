using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class SubAboutManager : ISubAboutService
{
     ISubAboutDal _subAboutDal;

     public SubAboutManager(ISubAboutDal subAboutDal)
     {
         _subAboutDal = subAboutDal;
     }

     public void TAdd(SubAbout entity)
     {
         _subAboutDal.Insert(entity);
     }

     public void TDelete(SubAbout entity)
     {
         _subAboutDal.Delete(entity);
     }

     public void TUpdate(SubAbout entity)
     {
         _subAboutDal.Update(entity);
     }

     public List<SubAbout> TGetList()
     {
         return _subAboutDal.GetList();
     }

     public SubAbout TGetByID(int id)
     {
         return _subAboutDal.GetByID(id);
     }
}