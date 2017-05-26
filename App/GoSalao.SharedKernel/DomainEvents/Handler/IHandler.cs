using GoSalao.SharedKernel.DomainEvents.Events;
using System;

namespace GoSalao.SharedKernel.DomainEvents.Handler
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);        
    }
}