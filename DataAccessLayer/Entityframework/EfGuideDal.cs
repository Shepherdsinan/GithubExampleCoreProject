using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.Entityframework;

public class EfGuideDal : GenericRepository<Guide>,IGuideDal
{
    public void ChangeGuideStat(int id)
    {
        Context c = new Context();
        var guide = c.Guides.Find(id);

        //Burada ternary operator kullandım.
        //Bu tek satır kodda anlatılmak istenen: eğer guide durumu true ise false, false ise true yap demek.
        guide.Status = guide.Status ? false : true;
        c.Update(guide);
        c.SaveChanges();
    }
}