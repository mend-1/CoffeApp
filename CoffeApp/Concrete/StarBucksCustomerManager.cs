using CoffeApp.Abstrsct;
using CoffeApp.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffieApp.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;   
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            
        }

        private void CheckIfRealPerson(Customer customer)
        {

        }
    }
}