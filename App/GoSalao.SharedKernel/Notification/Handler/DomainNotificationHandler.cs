using GoSalao.SharedKernel.DomainEvents.Handler;
using GoSalao.SharedKernel.Notification.Event;
using System.Collections.Generic;

namespace GoSalao.SharedKernel.Notification.Handler
{
    public class DomainNotificationHandler : IHandlerNotification
    {
        private List<DomainNotification> _notifications = new List<DomainNotification>();

        public void Handle(DomainNotification args)
        {
            this._notifications.Add(args);
        }

        public bool HasNotification()
        {
            return (this.GetValue().Count > 0);
        }

        public IEnumerable<DomainNotification> Notify()
        {
            return this.GetValue();
        }

        public void Dispose()
        {
            this._notifications = new List<DomainNotification>();
        }

        private List<DomainNotification> GetValue()
        {
            return this._notifications;
        }
    }
}