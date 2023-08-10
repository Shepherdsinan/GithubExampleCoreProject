using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.Entityframework;

public class EfAccountDal : GenericUowRepository<Account>, IAccountDal
{
    public EfAccountDal(Context context) : base(context)
    {
        
    }
}