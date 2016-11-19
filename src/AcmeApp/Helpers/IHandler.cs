using System;
using System.Collections.Generic;

namespace AcmeApp.Helpers
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
        List<T> GetValues();
    }
}
