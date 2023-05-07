using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.ViewComponents.Comment;

public class _AddComment : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}