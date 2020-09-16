using InterfaceCustomer;
using System;

namespace MiddleLayer
{


    public class Customer : CustomerBase
    {
        public Customer(IValidation<ICustomer> customer) : base(customer)
        {

        }
    }


}
