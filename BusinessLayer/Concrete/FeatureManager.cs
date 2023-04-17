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
        throw new NotImplementedException();
    }

    public void TDelete(Feature entity)
    {
        throw new NotImplementedException();
    }

    public void TUpdate(Feature entity)
    {
        throw new NotImplementedException();
    }

    public List<Feature> TGetList()
    {
        return _featureDal.GetList();
    }

    public Feature TGetByID(int id)
    {
        throw new NotImplementedException();
    }
}