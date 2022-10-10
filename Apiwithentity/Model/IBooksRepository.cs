namespace Apiwithentity.Model
{
    public interface IBooksRepository
    {
        List<Books> GetAllBooks();
        Books AddBooks(Books books);
        void DeleteBooks(int bookid);
        Books GetAllBooksByBookId(int id);
        Books UpdateBooks(Books books, int id);
    }
}
