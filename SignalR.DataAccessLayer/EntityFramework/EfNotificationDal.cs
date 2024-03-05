using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        public EfNotificationDal(SignalRContext context) : base(context)
        {
        }

        public List<Notification> GetAllNotificationByFalse()
        {
            throw new NotImplementedException();
        }

        public int NotificationCountByStatusFalse()
        {
            throw new NotImplementedException();
        }

        public void NotificationStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void NotificationStatusChangeToTrue(int id)
        {
            throw new NotImplementedException();
        }
    }
}
