using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.Entityframework;

public class EfTestimonial : GenericRepository<Testimonial>,ITestimonialDal
{
    
}