using EFCore_Lab.Data;
using EFCore_Lab.Models;

class Program
{
    static void Main(string[] args)
    {

        // we can use dotnet-ef to manage binding db by install with command `dotnet tool install -g dotnet-ef`
        // to migrate ef core with project we can use this command  `dotnet ef migrations add InitialCreate`
        // to remove migration we can use this command `dotnet ef migrations remove`
        // to migrade our code to database we can use this command `dotnet ef database update` after create migrations
        // if we have update model or context we must run command `dotnet ef migrations add MessageToLog` and use `dotnet ef database update` to update database

        Console.WriteLine("Hello, world!");

        #region Add Product Section

        // we use using because it ensure that PizzaContext it will be disposed off when done use it.
        using PizzaContext pizzaContext = new PizzaContext();

        Product hawaiiantPizza = new Product()
        {
            Name = "Deluxe Hawaiint Pizza1",
            Price = 399M
        };

        Product deluxeMeatPizza = new Product()
        {
            Name = "Deluxe Meat Pizza1",
            Price = 439M
        };

        pizzaContext.Add(hawaiiantPizza);
        pizzaContext.Products.Add(deluxeMeatPizza);

        // use SaveChanges() to persist the change to the database
        pizzaContext.SaveChanges();

        Console.WriteLine("Done!");

        #endregion
    }
}
