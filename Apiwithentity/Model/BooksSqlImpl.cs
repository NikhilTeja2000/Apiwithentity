namespace Apiwithentity.Model
{
    public class BooksSqlImpl : IBooksRepository
    {
        private readonly ToplistDbContext _dbContext;

        public BooksSqlImpl(ToplistDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public Books AddBooks(Books books)
        {
            _dbContext.Books.Add(books);
            _dbContext.SaveChanges();
            return books;
        }

        public void DeleteBooks(int bookid)
        {
            Books books = GetAllBooksByBookId(bookid);
            _dbContext.Books.Remove(books);
            _dbContext.SaveChanges();
        }

        public List<Books> GetAllBooks()
        {
            return _dbContext.Books.ToList();
        }

        public Books GetAllBooksByBookId(int id)
        {
            return _dbContext.Books.FirstOrDefault(emp => emp.Id == id);
        }

        public Books UpdateBooks(Books books, int id)

        {
            Books saveBook = GetAllBooksByBookId(id);

            saveBook.CategoryId = books.CategoryId;
            saveBook.ISBN = books.ISBN;
            saveBook.Title = books.Title;
            saveBook.Price = books.Price;
            saveBook.Year = books.Year;
            saveBook.Description = books.Description;
            saveBook.Position = books.Position;
            saveBook.Status = books.Status;
            saveBook.Image = books.Image;



            _dbContext.SaveChanges();
            return saveBook;

        }
    }
}
