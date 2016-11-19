using AcmeApp.Helpers;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace AcmeApp.Helpers
{
    public static class DomainEvent
    {
        public static IContainer Container { get; set; }

        public static void Raise<T>(T args) where T : IDomainEvent
        {
            if (Container == null) return;

            var obj = Container.GetService(typeof(IHandler<T>));
            ((IHandler<T>)obj).Handle(args);

        }
    }
}
