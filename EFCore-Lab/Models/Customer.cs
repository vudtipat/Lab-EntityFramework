namespace EFCore_Lab.Models;

public class Customer
{
	public int Id { set; get; }
	public string FirstName { set; get; } = null!;
    public string LastName { set; get; } = null!;
    public string? Address { set; get; }
    public string? Phone { set; get; }
    public string? Email { set; get; }
    public ICollection<Order> Orders { set; get; } = null!;
}

