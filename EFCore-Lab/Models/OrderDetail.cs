namespace EFCore_Lab.Models;

public class OrderDetail
{
    public int Id { set; get; }
    public int Quentity { set; get; }
    public int ProductId { set; get; }
    public int OrderId { set; get; }

    public Order Orders { set; get; } = null!;
    public Product Products { set; get; } = null!;
}