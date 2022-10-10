namespace Apiwithentity.Model
{
    public interface IUserWishlistRepository
    {
        List<Wishlist> GetAllWishlist();
        Wishlist GetWishlistById(int id);
        Wishlist AddWishlist(Wishlist wishlist);
        void DeleteToplist(int id);
        void UpdateWishlist(Wishlist wishlist);
    }
}
