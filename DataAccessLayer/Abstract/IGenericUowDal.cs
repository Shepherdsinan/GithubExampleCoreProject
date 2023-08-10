namespace DataAccessLayer.Abstract;

public interface IGenericUowDal<T> where T : class
{
    void Insert(T entity);
    void Update(T entity);
    void MultiUpdate(List<T> entity);
    T GetById(int id);
}