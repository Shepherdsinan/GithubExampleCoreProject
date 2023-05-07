namespace DataAccessLayer.Abstract;

public interface IGenericDal<T>
{
    void Insert(T entity);
    void Update(T entity);
    void Delete(T entity);

    List<T> GetList();

    T GetByID(int id);
}