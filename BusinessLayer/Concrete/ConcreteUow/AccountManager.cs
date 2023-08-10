using BusinessLayer.Abstract.AbstractUow;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete.ConcreteUow;

public class AccountManager : IAccountService
{
    private readonly IAccountDal _accountDal;
    private readonly IUowDal _uowDal;

    public AccountManager(IAccountDal accountDal, IUowDal uowDal)
    {
        _accountDal = accountDal;
        _uowDal = uowDal;
    }

    public void TInsert(Account entity)
    {
        _accountDal.Insert(entity);
        _uowDal.Save();
    }

    public void TUpdate(Account entity)
    {
        _accountDal.Update(entity);
        _uowDal.Save();
    }

    public void TMultiUpdate(List<Account> entity)
    {
        _accountDal.MultiUpdate(entity);
        _uowDal.Save();
    }

    public Account TGetById(int id)
    {
        return _accountDal.GetById(id);
    }
}