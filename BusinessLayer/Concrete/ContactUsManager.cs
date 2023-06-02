using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class ContactUsManager : IContactUsService
{
    private IContactUsDal _contactUsDal;

    public ContactUsManager(IContactUsDal contactUsDal)
    {
        _contactUsDal = contactUsDal;
    }

    public void TAdd(ContactUs entity)
    {
        _contactUsDal.Insert(entity);
    }

    public void TDelete(ContactUs entity)
    {
        _contactUsDal.Delete(entity);
    }

    public void TUpdate(ContactUs entity)
    {
        _contactUsDal.Update(entity);
    }

    public List<ContactUs> TGetList()
    {
        return _contactUsDal.GetList();
    }

    public ContactUs TGetByID(int id)
    {
        return _contactUsDal.GetByID(id);
    }

    public List<ContactUs> TGetlistContactUsByTrue()
    {
        return _contactUsDal.GetlistContactUsByTrue();
    }

    public List<ContactUs> TGetlistContactUsByFalse()
    {
        return _contactUsDal.GetlistContactUsByFalse();
    }

    public void TContactUsStatusChangeToFalse(int id)
    {
        throw new NotImplementedException();
    }
}