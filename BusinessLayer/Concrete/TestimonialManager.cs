using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class TestimonialManager : ITestimonialService
{
   ITestimonialDal _testimonialDal;

   public TestimonialManager(ITestimonialDal testimonialDal)
   {
      _testimonialDal = testimonialDal;
   }

   public void TAdd(Testimonial entity)
   {
      _testimonialDal.Insert(entity);
   }

   public void TDelete(Testimonial entity)
   {
      _testimonialDal.Delete(entity);
   }

   public void TUpdate(Testimonial entity)
   {
      _testimonialDal.Update(entity);
   }

   public List<Testimonial> TGetList()
   {
      return _testimonialDal.GetList();
   }

   public Testimonial TGetByID(int id)
   {
      return _testimonialDal.GetByID(id);
   }
}