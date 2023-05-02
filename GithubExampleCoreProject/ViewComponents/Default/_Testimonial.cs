using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.ViewComponents.Default;

public class _Testimonial : ViewComponent
{
    private TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
    public IViewComponentResult Invoke()
    {
        var values = testimonialManager.TGetList();
        return View(values);
    }
}