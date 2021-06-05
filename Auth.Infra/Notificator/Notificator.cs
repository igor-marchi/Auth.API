using System.Collections.Generic;
using Auth.Infra.Interface.Notificator;

namespace Auth.Infra.Notificator
{
    public class Notificator : INotificator
    {
        public List<Notification> GetNotifications()
        {
            throw new System.NotImplementedException();
        }

        public void HandleNotification(Notification notification)
        {
            throw new System.NotImplementedException();
        }

        public bool HasNotification()
        {
            throw new System.NotImplementedException();
        }
    }
}