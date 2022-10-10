namespace Apiwithentity.Model
{
    public class WishlistSqlImpl : IUserWishlistRepository
    {
        private readonly ToplistDbContext _dbContext;

        public WishlistSqlImpl(ToplistDbContext toplistDbContext)
        {
            this._dbContext = toplistDbContext;
        }
        public Wishlist AddWishlist(Wishlist wishlist)
        {

            _dbContext.Wishlists.Add(wishlist);
            _dbContext.SaveChanges();
            return  wishlist;
        }

        public void DeleteToplist(int id)
        {
            throw new NotImplementedException();
        }

        public List<Wishlist> GetAllWishlist()
        {
            return _dbContext.Wishlists.ToList();
        }

        public Wishlist GetWishlistById(int id)
        {

            return _dbContext.Wishlists.FirstOrDefault(emp => emp.UserId == id);
        }

       

        public void UpdateToplist(Wishlist wishlist)
        {
            throw new NotImplementedException();
        }

        public void UpdateWishlist(Wishlist wishlist)
        {
            throw new NotImplementedException();
        }
    }
}
