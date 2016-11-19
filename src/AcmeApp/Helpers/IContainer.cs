using System;
using System.Collections.Generic;

namespace AcmeApp.Helpers
{
    public interface IContainer
    {

        T GetInstance<T>();
        object GetInstance(Type serviceType);
        IEnumerable<T> GetAllInstances<T>();
        IEnumerable<object> GetAllInstances(Type serviceType);


        //Outra abordagem
        T GetService<T>();
        object GetService(Type serviceType);
        IEnumerable<T> GetServices<T>();
        IEnumerable<object> GetServices(Type serviceType);

    }
}
