using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.FunctionalDecompositionAntipattern
{
    public class Customer
    {
        public void ChangeFinancialStatus(bool status) { }
        public void AddCustomer(string name, string lastName, string address) { }
        public void UpdateAddress(string customerID, string address) { }
    }
}
