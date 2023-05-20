using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.Controllers;

public class CommentController : Controller
{
    private CommentManager _commentManager = new CommentManager(new EfCommentDal());
    [HttpGet]
    public PartialViewResult AddComment()
    {
        return PartialView();
    }

    [HttpPost]
    public IActionResult AddComment(Comment p)
    {
        p.CommentDate = Convert.ToDateTime((DateTime.Now.ToShortDateString()));
        p.CommentState = true;
        _commentManager.TAdd(p);
        return RedirectToAction("Index", "Destination");
    }
}