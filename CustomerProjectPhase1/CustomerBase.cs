using System;
using System.Collections.Generic;
using System.Text;
using InterfaceCustomer;

namespace MiddleLayer
{
    public class CustomerBase : ICustomer
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

        public virtual void Validate()
        {
            throw new Exception("Not implemented");
        }
    }
}
