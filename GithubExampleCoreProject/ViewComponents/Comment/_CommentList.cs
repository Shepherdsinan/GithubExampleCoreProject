using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.ViewComponents.Comment;

public class _CommentList: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}