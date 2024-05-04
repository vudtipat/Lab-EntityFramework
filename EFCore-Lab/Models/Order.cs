namespace EFCore_Lab.Models;

public class Order
{
    public int Id { set; get; }
    public DateTime OrderPlaced { set; get; }
    public DateTime? OrderFullFilled { set; get; }
    public int CustomerId { set; get; }

    public Customer Customer { set; get; } = null!;
    public ICollection<OrderDetail> OrderDetails { set; get; } = null!;
}