using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract;

public interface IContactUsDal : IGenericDal<ContactUs>
{
    List<ContactUs> GetlistContactUsByTrue();
    List<ContactUs> GetlistContactUsByFalse();
    void ContactUsStatusChangeToFalse(int id);
}