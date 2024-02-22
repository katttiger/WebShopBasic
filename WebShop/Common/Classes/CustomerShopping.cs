namespace WebShop.Common.Classes
{
    public class CustomerShopping
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ShoppingListId { get; set; }

        public CustomerShopping() { }
        public CustomerShopping(int id, int customerId, int shoppinglistId) => (Id, CustomerId, ShoppingListId) = (id, customerId, shoppinglistId);
    }
}
