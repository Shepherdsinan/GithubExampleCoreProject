using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repository;

public class GenericUowRepository<T> : IGenericUowDal<T> where T : class
{
    private readonly Context _context;

    public GenericUowRepository(Context context)
    {
        _context = context;
    }

    public void Insert(T entity)
    {
        _context.Add(entity);
    }

    public void Update(T entity)
    {
        _context.Update(entity);
    }

    public void MultiUpdate(List<T> entity)
    {
        _context.UpdateRange(entity);
    }

    public T GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }
}