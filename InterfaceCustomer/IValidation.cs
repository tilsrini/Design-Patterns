using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCustomer
{
    public interface IValidation<AnyType>
    {
        void Validate(AnyType obj);
    }
}
