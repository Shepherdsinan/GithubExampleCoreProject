using System.Security.Cryptography;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.Entityframework;

public class EfDestinationDal:GenericRepository<Destination>,IDestinationDal
{
    
}