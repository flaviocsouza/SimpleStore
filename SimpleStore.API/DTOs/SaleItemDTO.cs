namespace SimpleStore.API.DTOs;

public class SaleItemDTO
{
    public string ProductId { get; set; }
    public string SaleId { get; set; }
    public int Quantity { get; set; }

    public ProductDTO Product { get; set; }
    public SaleDTO Sale { get; set; }

}
