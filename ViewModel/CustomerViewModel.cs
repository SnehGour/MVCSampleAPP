using MVCSampleAPP.Models;

namespace MVCSampleAPP.ViewModel
{
    public class CustomerViewModel
    {
        public string Connection { get; set; }
        public IList<Customer> Customers { get; set; }
    }
}
