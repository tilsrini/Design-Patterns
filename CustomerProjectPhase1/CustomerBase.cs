using System;
using System.Collections.Generic;
using System.Text;
using InterfaceCustomer;

namespace MiddleLayer
{
    public class CustomerBase : ICustomer
    {
        private IValidation<ICustomer> _validation = null;

        public CustomerBase()
        {
            CustomerName = "";
            PhoneNumber = "";
            BillAmount = 0;
            BillDate = DateTime.Now;
            Address = "";
        }

        public CustomerBase(IValidation<ICustomer> validation)
        {
            _validation = validation;
        }

        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }


        public virtual void Validate()
        {
            _validation.Validate(this);
        }
    }
}
