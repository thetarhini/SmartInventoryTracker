namespace SIT.Core.Entities
{
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public int SupplierId { get; set; }
    public int StockQuantity { get; set; }
    public int ReorderLevel { get; set; }

    public Category Category { get; set; }
    public Supplier Supplier { get; set; }
}
}
