﻿using System;
using System.Threading.Tasks;

using Castle.Windsor;

namespace DynamicTranslator.Dependency.Manager
{
    public interface IIocManager : IIocRegistrar, IIocResolver, IDisposable
    {
        IWindsorContainer IocContainer { get; }

        Task DisposeAsync();

        new bool IsRegistered(Type type);

        new bool IsRegistered<T>();
    }
}