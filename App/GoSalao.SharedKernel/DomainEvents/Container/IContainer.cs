﻿using System;
using System.Collections.Generic;

namespace GoSalao.SharedKernel.DomainEvents.Container
{
    public interface IContainer
    {
        T GetService<T>();

        object GetService(Type serviceType);

        IEnumerable<T> GetServices<T>();

        IEnumerable<object> GetServices(Type serviceType);
    }
}