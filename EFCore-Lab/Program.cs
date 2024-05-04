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

        // we use using because it ensure that PizzaContext it will be disposed off when done use it.
        using PizzaContext pizzaContext = new PizzaContext();

        #region Add Product Section

        //Product hawaiiantPizza = new Product()
        //{
        //    Name = "Deluxe Hawaiint Pizza1",
        //    Price = 399M
        //};

        //Product deluxeMeatPizza = new Product()
        //{
        //    Name = "Deluxe Meat Pizza1",
        //    Price = 439M
        //};

        //pizzaContext.Add(hawaiiantPizza);
        //pizzaContext.Products.Add(deluxeMeatPizza);

        //// use SaveChanges() to persist the change to the database
        //pizzaContext.SaveChanges();

        //Console.WriteLine("Done!");

        #endregion

        #region Get Product Section

        //var products = pizzaContext.Products
        //        .Where(p => p.Price > 300)
        //        .OrderBy(p => p.Name);

        //foreach(var product in products)
        //{
        //    Console.WriteLine("============================");
        //    Console.WriteLine($"ID: {product.Id}");
        //    Console.WriteLine($"Name: {product.Name}");
        //    Console.WriteLine($"Price: {product.Price}");
        //    Console.WriteLine("============================");
        //}

        #endregion

        #region Update Product Section

        //var product = pizzaContext.Products
        //        .Where(p => p.Id == 1)
        //        .FirstOrDefault();

        //if(product is not null)
        //{
        //    product.Price = 100M;
        //}

        //pizzaContext.SaveChanges();

        #endregion

        #region Remove Product Section

        var product = pizzaContext.Products
                .Where(p => p.Id == 1)
                .FirstOrDefault();

        if (product is not null)
        {
            pizzaContext.Remove(product);
        }

        pizzaContext.SaveChanges();

        #endregion
    }
}
