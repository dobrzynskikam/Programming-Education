using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KamilCofeeStore.StockManagement.Model;
using KamilCoffeeStore.StockManagement.DAL;

namespace KamilCoffeeStore.StockManagement.App.Services
{
    public class CoffeeDataService : IDataService
    {
        ICoffeeRepository repository = new CoffeeRepository(); 

        public void DeleteCoffee(Coffee coffee)
        {
            repository.DeleteCoffee(coffee);
        }

        public List<Coffee> GetAllCoffees()
        {
            return repository.GetCoffees();
        }

        public Coffee GetCoffeeDetail(int coffeeId)
        {
            return repository.GetCoffeeById(coffeeId);
        }

        public void UpdateCoffee(Coffee coffee)
        {
            repository.UpdateCoffee(coffee);
        }
    }
}
