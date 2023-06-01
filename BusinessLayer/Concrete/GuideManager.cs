using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class GuideManager : IGuideService
{
    IGuideDal _guideDal;

    public GuideManager(IGuideDal guideDal)
    {
        _guideDal = guideDal;
    }

    public void TAdd(Guide entity)
    {
        _guideDal.Insert(entity);
    }

    public void TDelete(Guide entity)
    {
        _guideDal.Delete(entity);
    }

    public void TUpdate(Guide entity)
    {
        _guideDal.Update(entity);
    }

    public List<Guide> TGetList()
    {
        return _guideDal.GetList();
    }

    public Guide TGetByID(int id)
    {
        return _guideDal.GetByID(id);
    }

    public void ChangeGuideStat(int id)
    {
       _guideDal.ChangeGuideStat(id);
    }
}