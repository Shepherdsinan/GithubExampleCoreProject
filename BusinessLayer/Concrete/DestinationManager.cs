using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class DestinationManager : IDestinationService
{
    private IDestinationDal _destinationDal;

    public DestinationManager(IDestinationDal destinationDal)
    {
            _destinationDal=destinationDal;
    }

    public void TAdd(Destination entity)
    {
        throw new NotImplementedException();
    }

    public void TDelete(Destination entity)
    {
        throw new NotImplementedException();
    }

    public Destination TGetByID(int id)
    {
        return _destinationDal.GetByID(id);
    }

    public List<Destination> TGetList()
    {
      return  _destinationDal.GetList();
    }

    public void TUpdate(Destination entity)
    {
        throw new NotImplementedException();
    }
}