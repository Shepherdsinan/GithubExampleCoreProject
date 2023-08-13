using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.ViewComponents.Comment;

public class _CommentList: ViewComponent
{
    private CommentManager commentManager = new CommentManager(new EfCommentDal());
    Context c = new Context();
        
    public IViewComponentResult Invoke(int id)
    {
        ViewBag.commentCount = c.Comments.Count(x => x.DestinationID == id);
        var values = commentManager.TGetListCommentWithDestinationandUser(id);
        return View(values);
    }
}