namespace SimpleStore.API.DTOs;

public class ProductSupplierDTO
{
    public Guid SupplierId { get; set; }
    public Guid ProductId { get; set; }
    public decimal Price { get; set; }

    public ProductDTO Product { get; set; }
    public SupplierDTO Supplier { get; set; }
}
