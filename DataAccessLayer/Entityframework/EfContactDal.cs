using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.Entityframework;

public class EfContactDal:GenericRepository<Contact>,IContactDal
{
    
}