using MiddleLayer;
using System;
using System.Collections.Generic;

namespace FactoryCustomer
{
    public static class Factory
    {
        private static Dictionary<string, CustomerBase> custs = new Dictionary<string, CustomerBase>();


        public static CustomerBase Create(string custType)
        {
            if (custs.Count == 0)
            {
                custs.Add("Customer", new Customer());
                custs.Add("Lead", new Lead());
            }

            return custs[custType];
        }
    }
}
