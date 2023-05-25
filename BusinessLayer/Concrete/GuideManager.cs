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
        throw new NotImplementedException();
    }

    public void TDelete(Guide entity)
    {
        throw new NotImplementedException();
    }

    public void TUpdate(Guide entity)
    {
        throw new NotImplementedException();
    }

    public List<Guide> TGetList()
    {
        return _guideDal.GetList();
    }

    public Guide TGetByID(int id)
    {
        throw new NotImplementedException();
    }
}