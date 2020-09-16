using InterfaceCustomer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiddleLayer
{
    public class Lead : CustomerBase
    {
        public Lead(IValidation<ICustomer> lead) : base(lead)
        {

        }
    }
}
