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
      throw new NotImplementedException();
   }

   public void TDelete(Testimonial entity)
   {
      throw new NotImplementedException();
   }

   public void TUpdate(Testimonial entity)
   {
      throw new NotImplementedException();
   }

   public List<Testimonial> TGetList()
   {
      return _testimonialDal.GetList();
   }

   public Testimonial TGetByID(int id)
   {
      throw new NotImplementedException();
   }
}