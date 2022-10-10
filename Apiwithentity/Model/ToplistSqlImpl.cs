namespace Apiwithentity.Model
{
    public class ToplistSqlImpl : IToplistRepository
    {
        private readonly ToplistDbContext _dbContext;

        public ToplistSqlImpl(ToplistDbContext toplistDbContext)
        {
            this._dbContext = toplistDbContext;
        }

      
        public Toplist AddToplist(Toplist toplist)
        {

            _dbContext.Toplists.Add(toplist);
            _dbContext.SaveChanges();
            return toplist;
        }

        public void DeleteToplist(int id)
        {
            throw new NotImplementedException();
        }

        public List<Toplist> GetAllToplist()
        {
            return _dbContext.Toplists.ToList();
        }

        public Toplist GetToplistById(int id)
        {
            return _dbContext.Toplists.FirstOrDefault(emp => emp.Id == id);
        }

        public void UpdateToplist(Toplist toplist)
        {
            throw new NotImplementedException();
        }
    }
}
