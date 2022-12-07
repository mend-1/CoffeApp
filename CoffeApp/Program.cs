using CoffeApp.Abstrsct;
using CoffeApp.Concrete;
using CoffeApp.Entityes;

namespace CoffeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            BaseCustomerManager baseCustomerManager= new NeroCustomerManager();
            baseCustomerManager.Save(new Customer
            {
                DateOfBrith = new DateTime(1985, 1, 6),
                Name = "Engin",
                LastName = "Demiroğ",
                NationalityId = "23322323"
            }
            );
        }
    }
}