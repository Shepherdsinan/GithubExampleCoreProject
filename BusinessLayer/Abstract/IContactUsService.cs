using EntityLayer.Concrete;

namespace BusinessLayer.Abstract;

public interface IContactUsService : IGenericService<ContactUs>
{
    List<ContactUs> TGetlistContactUsByTrue();
    List<ContactUs> TGetlistContactUsByFalse();
    void TContactUsStatusChangeToFalse(int id);
}