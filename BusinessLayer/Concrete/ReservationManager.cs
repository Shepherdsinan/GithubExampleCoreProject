using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class ReservationManager : IReservationService
{
    private IReservationDal _reservationDal;

    public ReservationManager(IReservationDal reservationDal)
    {
        _reservationDal = reservationDal;
    }

    public void TAdd(Reservation entity)
    {
        _reservationDal.Insert(entity);
    }

    public void TDelete(Reservation entity)
    {
        throw new NotImplementedException();
    }

    public void TUpdate(Reservation entity)
    {
        throw new NotImplementedException();
    }

    public List<Reservation> TGetList()
    {
        throw new NotImplementedException();
    }

    public Reservation TGetByID(int id)
    {
        throw new NotImplementedException();
    }

    public List<Reservation> GetListWithReservationByWaitApproval(int id)
    {
        return _reservationDal.GetListWithReservationByWaitApproval(id);
    }

    public List<Reservation> GetListWithReservationByAccepted(int id)
    {
        return _reservationDal.GetListWithReservationByAccepted(id);
    }

    public List<Reservation> GetListWithReservationByPrevious(int id)
    {
        return _reservationDal.GetListWithReservationByPrevious(id);
    }

    // public List<Reservation> GetListApprovalReservation(int id)
    // {
    //     return _reservationDal.GetListByFilter(x => x.AppUserId == id && x.Status =="Onay Bekliyor");
    // }
}