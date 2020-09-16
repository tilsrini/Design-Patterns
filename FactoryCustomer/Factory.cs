using System;
using Unity;
using InterfaceCustomer;
using MiddleLayer;
using ValidationStrategyORAlgorithems;
using Unity.Injection;

namespace FactoryCustomer
{
    public static class Factory
    {

        private static IUnityContainer custs = null;

        public static ICustomer Create(string custType)
        {
            if (custs == null)
            {
                custs = new UnityContainer();
                custs.RegisterType<ICustomer, Customer>("Customer", new InjectionConstructor(new CustomerValidation()));
                custs.RegisterType<ICustomer, Lead>("Lead", new InjectionConstructor(new LeadValidation()));
            }

            return custs.Resolve<ICustomer>(custType);
        }
    }
}
