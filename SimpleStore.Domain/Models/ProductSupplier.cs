namespace SimpleStore.Domain.Models;

public class ProductSupplier : BaseEntity
{
    public Guid SupplierId { get; set; }
    public Guid ProductId { get; set; }
    public decimal Price { get; set; }

    public Product Product { get; set; }
    public Supplier Supplier { get; set; }
}