using CoffeApp.Abstrsct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeApp.Entityes
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBrith { get; set; }
        public string NationalityId { get; set; }
    }
}
