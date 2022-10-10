namespace Apiwithentity.Model
{
    public class UserdetailsSqlImpl : IUserdetailsRepository
    {
        private readonly ToplistDbContext _dbContext;
        public UserdetailsSqlImpl(ToplistDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Userdetails AddUserdetials(Userdetails userdetails)
        {
            _dbContext.Userdetails.Add(userdetails);
            _dbContext.SaveChanges();
            return userdetails;
        }

        public void DeleteUserdetails(int id)
        {
            Userdetails userdetails = GetAllUserdetailsById(id);
            _dbContext.Userdetails.Remove(userdetails);
            _dbContext.SaveChanges();
        }

        public List<Userdetails> GetAllUserdetails()
        {

            return _dbContext.Userdetails.ToList();
        }

        public Userdetails GetAllUserdetailsById(int id)
        {
            return _dbContext.Userdetails.FirstOrDefault(emp => emp.Id == id);
        }

        public Userdetails UpdateUserdetails(Userdetails userdetails, int id)
        {
            Userdetails saveBook = GetAllUserdetailsById(id);
            saveBook.Name = userdetails.Name;
            saveBook.Password = userdetails.Password;
            _dbContext.SaveChanges();
            return saveBook;
        }
    }
}
