using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.Entityframework;

public class EfGuideDal : GenericRepository<Guide>,IGuideDal
{
    
}