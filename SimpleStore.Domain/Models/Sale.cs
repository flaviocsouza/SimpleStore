namespace SimpleStore.Domain.Models;

public class Sale : BaseEntity 
{
    public Guid CustomerId { get; set; }
    public DateTime SaleDate { get; set; }

    public List<SaleItem> SaleItems { get; set; }
    public Customer Customer { get; set; }

}
