namespace BusinessLayer.Abstract.AbstractUow;

public interface IGenericUowService<T>
{
    void TInsert(T entity);
    void TUpdate(T entity);
    void TMultiUpdate(List<T> entity);
    T TGetById(int id);
}