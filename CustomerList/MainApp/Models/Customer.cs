namespace MainApp.Models;

public class Customer
{
    public string CustomerName { get; set; } = null!;

    public ContactInformation ContactInformation { get; set; } = null!;
    public ContactPerson? ContactPerson { get; set; }

    public Adress BillingAdress { get; set; } = null!;
  
    public Adress DeliveryAdress { get; set; } = null!;

    public CustomerService? CustomerService { get; set; }

    public Customer? CustomerList { get; set; } 



    // CustomerName
    // ContactPerson -> CustomerContactPerson
    // ContactInformation -> CustomerContactInformation
    // BillingAddress -> Address
    // DeliveryAddress -> Address
}
