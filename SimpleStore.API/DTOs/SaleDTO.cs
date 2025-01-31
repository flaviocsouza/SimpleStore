namespace SimpleStore.API.DTOs;

public class SaleDTO
{
    public Guid CustomerId { get; set; }
    public DateTime SaleDate { get; set; }

    public List<SaleItemDTO> SaleItems { get; set; }
    public CustomerDTO Customer { get; set; }
}
