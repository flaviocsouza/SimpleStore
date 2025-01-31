namespace SimpleStore.Domain.Models;

public class Supplier : BaseEntity 
{
    public string Name { get; set; }
    public string ContactName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public List<Product> Products { get; set; }
    public List<ProductSupplier> ProductsSuppliers { get; set; }
}
