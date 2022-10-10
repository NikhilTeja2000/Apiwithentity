namespace Apiwithentity.Model
{
    public interface ICartRepository
    {

        List<Cart> GetAllCart();
        Cart GetCartById(int id);
        Cart AddCart(Cart cart);
        void DeleteCart(int id);
        void UpdateCart(Cart cart);
    }
}
