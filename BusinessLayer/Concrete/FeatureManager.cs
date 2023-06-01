using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class FeatureManager : IFeatureService
{
    private IFeatureDal _featureDal;

    public FeatureManager(IFeatureDal featureDal)
    {
        _featureDal = featureDal;
    }

    public void TAdd(Feature entity)
    {
        _featureDal.Insert(entity);
    }

    public void TDelete(Feature entity)
    {
        _featureDal.Delete(entity);
    }

    public void TUpdate(Feature entity)
    {
        _featureDal.Update(entity);
    }

    public List<Feature> TGetList()
    {
        return _featureDal.GetList();
    }

    public Feature TGetByID(int id)
    {
        return _featureDal.GetByID(id);
    }
}