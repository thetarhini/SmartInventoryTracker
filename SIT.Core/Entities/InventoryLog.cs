namespace SIT.Core.Entities
{
public class InventoryLog
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int QuantityChanged { get; set; }
    public string Reason { get; set; }
    public DateTime Timestamp { get; set; }

    public Product Product { get; set; }
}
}
