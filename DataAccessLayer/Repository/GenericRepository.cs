using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repository;

public class GenericRepository<T> : IGenericDal<T> where T : class
{
    public void Delete(T entity)
    {
        using var c = new Context();
        c.Remove(entity);
        c.SaveChanges();
    }

    public List<T> GetList()
    {
        using var c = new Context();
        return c.Set<T>().ToList();
    }

    public void Insert(T entity)
    {
        using var c = new Context();
        c.Add(entity);
    }

    public void Update(T entity)
    {
        using var c = new Context();
        c.Update(entity);
    }
}