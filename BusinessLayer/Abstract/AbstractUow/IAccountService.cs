using EntityLayer.Concrete;

namespace BusinessLayer.Abstract.AbstractUow;

public interface IAccountService : IGenericUowService<Account>
{
    
}