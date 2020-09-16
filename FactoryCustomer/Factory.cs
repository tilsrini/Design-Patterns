using System;
using Unity;
using InterfaceCustomer;
using MiddleLayer;

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
                custs.RegisterType<ICustomer, Customer>("Customer");
                custs.RegisterType<ICustomer, Lead>("Lead");
            }

            return custs.Resolve<ICustomer>(custType);
        }
    }
}
