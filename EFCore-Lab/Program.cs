using EFCore_Lab.Data;
using EFCore_Lab.Models;

class Program
{
    static void Main(string[] args)
    {

        #region migrate db from exist db to code
        // use this command to reverse exist db to code by use this command `dotnet ef dbcontext scaffold "connectionString" Microsoft.EntityFrameworkCore.SqlServer --context-dir contextDirProj --output-dir TableModelDirProj --context-namespace ProjNameSpaceContext --namespace ProjNameSpace`
        // example `dotnet ef dbcontext scaffold "Server=ip;Database=Demo;User Id=usr;Password=pwd;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer --context-dir Data --output-dir Models/Generated --context-namespace EFCore_Lab.Data --namespace EFCore_Lab.Models`


        #endregion

        #region migrate db from code to db

        // we can use dotnet-ef to manage binding db by install with command `dotnet tool install -g dotnet-ef`
        // to migrate ef core with project we can use this command  `dotnet ef migrations add InitialCreate`
        // to remove migration we can use this command `dotnet ef migrations remove`
        // to migrade our code to database we can use this command `dotnet ef database update` after create migrations
        // if we have update model or context we must run command `dotnet ef migrations add MessageToLog` and use `dotnet ef database update` to update database

        // we use using because it ensure that PizzaContext it will be disposed off when done use it.

        //using PizzaContext pizzaContext = new PizzaContext();

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

        //var product = pizzaContext.Products
        //        .Where(p => p.Id == 1)
        //        .FirstOrDefault();

        //if (product is not null)
        //{
        //    pizzaContext.Remove(product);
        //}

        //pizzaContext.SaveChanges();

        #endregion

        #endregion
    }
}
