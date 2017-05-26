using GoSalao.SharedKernel.DomainEvents;
using GoSalao.SharedKernel.DomainEvents.Handler;
using GoSalao.SharedKernel.Notification.Event;

namespace GoSalao.SharedKernel.ServiceNotification
{
    public class ServiceNotification
    {
        private readonly IHandler<DomainNotification> _notifications;

        private ServiceNotification()
        {
            _notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
        }

        public bool HasNotifications()
        {
            return _notifications.HasNotifications();
        }
    }
}