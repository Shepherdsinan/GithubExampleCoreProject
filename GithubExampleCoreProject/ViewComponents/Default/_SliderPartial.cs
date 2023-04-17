using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
