using EntityLayer.Concrete;

namespace BusinessLayer.Abstract;

public interface IGuideService : IGenericService<Guide>
{
    void ChangeGuideStat(int id);
}