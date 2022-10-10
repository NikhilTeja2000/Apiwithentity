namespace Apiwithentity.Model
{
    public interface IToplistRepository
    {
        List<Toplist> GetAllToplist();
        Toplist GetToplistById(int id);
        Toplist AddToplist(Toplist toplist);
        void DeleteToplist(int id);
        void UpdateToplist(Toplist toplist);
    }
}
