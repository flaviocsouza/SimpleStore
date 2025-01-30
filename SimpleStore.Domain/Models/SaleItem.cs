namespace SimpleStore.Domain.Models;

public class SaleItem : BaseEntity
{
    public string ProductId { get; set; }
    public string SaleId { get; set; }
    public int Quantity { get; set; }

    public Product Product { get; set; }
    public Sale Sale { get; set; }

}