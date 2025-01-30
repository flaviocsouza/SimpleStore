namespace SimpleStore.Domain.Models;

public class Customer : BaseEntity 
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    public List<Sale> Sales { get; set; }

}
