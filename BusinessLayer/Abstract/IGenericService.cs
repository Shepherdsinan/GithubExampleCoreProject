using System.Linq.Expressions;

namespace BusinessLayer.Abstract;

public interface IGenericService<T>
{
    void TAdd(T entity);
    void TDelete(T entity);
    void TUpdate(T entity);
    List<T> TGetList();

    T TGetByID(int id);

    //List<T> GetByFilter(Expression<Func<T, bool>> filter);
}