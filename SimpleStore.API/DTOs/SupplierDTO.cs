namespace SimpleStore.API.DTOs;

public class SupplierDTO
{
    public string Name { get; set; }
    public string ContactName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public List<ProductDTO> Products { get; set; }
    public List<ProductSupplierDTO> ProductsSuppliers { get; set; }
}