using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
	{
		public EfBookingDal(SignalRContext context) : base(context)
		{
		}

        public void BookingStatusApproved(int id)
        {
            throw new NotImplementedException();
        }

        public void BookingStatusCancelled(int id)
        {
            throw new NotImplementedException();
        }
    }
}
