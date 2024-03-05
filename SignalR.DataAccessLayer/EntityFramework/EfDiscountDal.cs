using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
    {
        public EfDiscountDal(SignalRContext context) : base(context)
        {
        }

        public void ChangeStatusToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void ChangeStatusToTrue(int id)
        {
            throw new NotImplementedException();
        }

        public List<Discount> GetListByStatusTrue()
        {
            throw new NotImplementedException();
        }
    }
}
