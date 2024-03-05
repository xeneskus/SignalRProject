using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        public EfOrderDal(SignalRContext context) : base(context)
        {
        }

        public int ActiveOrderCount()
        {
            throw new NotImplementedException();
        }

        public decimal LastOrderPrice()
        {
            throw new NotImplementedException();
        }

        public decimal TodayTotalPrice()
        {
            throw new NotImplementedException();
        }

        public int TotalOrderCount()
        {
            throw new NotImplementedException();
        }
    }
}
