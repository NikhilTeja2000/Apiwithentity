namespace Apiwithentity.Model
{
    public class CartSqlImpl : ICartRepository
    {
        private readonly ToplistDbContext _dbContext;

        public CartSqlImpl(ToplistDbContext toplistDbContext)
        {
            this._dbContext = toplistDbContext;
        }
        public Cart AddCart(Cart cart)
        {


            _dbContext.Cart.Add(cart);
            _dbContext.SaveChanges();
            return cart;
        }

        public void DeleteCart(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cart> GetAllCart()
        {

            return _dbContext.Cart.ToList();
        }

        public Cart GetCartById(int id)
        {
            return _dbContext.Cart.FirstOrDefault(emp => emp.UserId == id);
        }

        public void UpdateCart(Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}
