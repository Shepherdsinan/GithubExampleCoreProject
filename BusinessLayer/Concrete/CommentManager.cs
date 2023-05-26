using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class CommentManager : ICommentService
{
    private ICommentDal _commentDal;

    public CommentManager(ICommentDal commentDal)
    {
        _commentDal = commentDal;
    }
    public void TAdd(Comment entity)
    {
        _commentDal.Insert(entity);
    }

    public void TDelete(Comment entity)
    {
        _commentDal.Delete(entity);
    }

    public void TUpdate(Comment entity)
    {
        _commentDal.Update(entity);
    }

    public List<Comment> TGetList()
    {
        return _commentDal.GetList();
    }

    public List<Comment> TGetDestinationById(int id)
    {
        return _commentDal.GetListByFilter(x => x.DestinationID == id);
    }

    public List<Comment> TGetListCommentWithDestination()
    {
        return _commentDal.GetListCommentWithDestination();
    }

    public Comment TGetByID(int id)
    {
        return _commentDal.GetByID(id);
    }
}