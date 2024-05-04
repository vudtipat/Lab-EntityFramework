using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_Lab.Models;

public class Product
{
	public int Id { set; get; }
	public string Name { set; get; } = null!;
	[Column(TypeName = "decimal(6, 2)")]
	public decimal Price { set; get; }
}

