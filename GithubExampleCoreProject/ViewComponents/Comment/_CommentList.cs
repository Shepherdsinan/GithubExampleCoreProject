using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.ViewComponents.Comment;

public class _CommentList: ViewComponent
{
    private CommentManager commentManager = new CommentManager(new EfCommentDal());
    public IViewComponentResult Invoke(int id)
    {
        var values = commentManager.TGetDestinationById(id);
        return View(values);
    }
}