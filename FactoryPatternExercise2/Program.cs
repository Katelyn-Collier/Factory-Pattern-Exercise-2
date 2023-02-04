namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which database would you like to work with?");
            Console.WriteLine("> sql");
            Console.WriteLine("> mongo");
            Console.WriteLine("> list");

            var userInput = Console.ReadLine();

            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();

            foreach(var product in products)
            {
                Console.WriteLine($"Name: {product.Name} -- Price: {product.Price}");
            }
        }
    }
}
