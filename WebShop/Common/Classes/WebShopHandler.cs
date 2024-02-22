using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using WebShop.Common.Data;

namespace WebShop.Common.Classes
{
    public class WebShopHandler
    {
        public CollectionData _db = new CollectionData();
        public WebShopHandler() => _db.SeedData();

        public Customer Customer = new();

        public CustomerShopping CustomerShopping = new();

        public List<Product> GetListAsync() => _db.GetList();

        public async Task<Product> GetProductById(int id)
        {
            var result = _db.Products.Find(x => x.Id == id);
            return result;
        }
        public async Task AddToShoppingList(Product product) => _db.ShoppingList.Add(product);

        public void AddCustomer(string name, string adress)
        {
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(adress))
            {
                Customer customer = _db.AddCustomer(name, adress);
            }
            else if (!string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Name is null or empty");
            else if (!string.IsNullOrWhiteSpace(adress))
                throw new ArgumentNullException("Adress is null or empty");
            else
                throw new ArgumentNullException("Adress and name is null or empty");
        }

        public void AddCustomerShopping(Customer Customer)
        {
            var customerShopper=_db.AddCustomerShopping(Customer);
            CustomerShopping= customerShopper;
        }
    }
}
