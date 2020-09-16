using InterfaceCustomer;
using System;

namespace ValidationStrategyORAlgorithems
{
    public class LeadValidation : IValidation<ICustomer>
    {
        public void Validate(ICustomer leadCustomer)
        {
            if (leadCustomer.CustomerName.Length == 0)
            {
                throw new Exception("Customer Name is required");
            }

            if (leadCustomer.PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required");
            }
        }
    }
}
