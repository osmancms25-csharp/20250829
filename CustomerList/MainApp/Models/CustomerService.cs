namespace MainApp.Models;

public class CustomerService
{
   public List<Customer> customerList = [];

    public void Create(Customer customer)

    {
        
        customerList.Add(customer);

    }

    public IEnumerable<Customer> GetAll()
    {
        return customerList;
    }
}

