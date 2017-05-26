using GoSalao.SharedKernel.DomainEvents.Events;

namespace GoSalao.SharedKernel.Notification.Event
{
    public class DomainNotification : IDomainEvent
    {
        public string Key { get; }

        public string Value { get; }


        public DomainNotification(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}