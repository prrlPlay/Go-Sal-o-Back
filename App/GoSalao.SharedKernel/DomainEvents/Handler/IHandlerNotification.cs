using GoSalao.SharedKernel.Notification.Event;
using System.Collections.Generic;

namespace GoSalao.SharedKernel.DomainEvents.Handler
{
    public interface IHandlerNotification: IHandler<DomainNotification>
    {
        bool HasNotification();

        IEnumerable<DomainNotification> Notify();
    }
}