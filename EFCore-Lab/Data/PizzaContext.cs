using System;
using EFCore_Lab.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Lab.Data;

public class PizzaContext: DbContext
{
	public DbSet<Customer> Customers { set; get; } = null!;
    public DbSet<Order> Orders { set; get; } = null!;
    public DbSet<Product> Products { set; get; } = null!;
    public DbSet<OrderDetail> OrderDetails { set; get; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Input Connection String here");
    }
}
