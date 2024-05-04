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
    }
}
