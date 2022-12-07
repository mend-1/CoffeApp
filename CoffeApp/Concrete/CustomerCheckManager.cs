using CoffeApp.Abstrsct;
using CoffeApp.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeApp.Concrete
{
    internal class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
