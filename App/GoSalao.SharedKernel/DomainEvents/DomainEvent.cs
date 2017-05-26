using GoSalao.SharedKernel.DomainEvents.Container;
using GoSalao.SharedKernel.DomainEvents.Events;
using GoSalao.SharedKernel.DomainEvents.Handler;

namespace GoSalao.SharedKernel.DomainEvents
{
    public static class DomainEvent
    {
        public static IContainer Container { get; set; }

        public static void Raise<T>(T evento) where T : IDomainEvent
        {
            ((IHandler<T>)Container.GetService(typeof(IHandler<T>))).Handle(evento);
        }
    }
}