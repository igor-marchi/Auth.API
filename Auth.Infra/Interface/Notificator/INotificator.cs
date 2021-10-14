using System.Collections.Generic;
using Auth.Infra.Notificator;

namespace Auth.Infra.Interface.Notificator
{
    public interface INotificator
    {
        bool HasNotification();

        List<Notification> GetNotifications();

        void HandleNotification(Notification notification);
    }
}