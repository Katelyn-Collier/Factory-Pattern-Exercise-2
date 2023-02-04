using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
           new Product (){Name = "Nintendo Switch", Price = 300},
           new Product (){Name = "Xbox Series S", Price = 250},
           new Product (){Name = "PS5", Price = 500},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a Mongo Data Access.");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a Mongo Data Access");
        }
    }
}
