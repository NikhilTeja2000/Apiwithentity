namespace Apiwithentity.Model
{
    public class CategorySqlImpl : ICategoryRepository
    {
        private readonly ToplistDbContext _dbContext;

        public CategorySqlImpl(ToplistDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Category AddCategory(Category category)
        {
            _dbContext.Category.Add(category);
            _dbContext.SaveChanges();
            return category;
        }

        public void DeleteCategory(int id)
        {
            Category category = GetAllCategoryById(id);
            _dbContext.Category.Remove(category);
            _dbContext.SaveChanges();
        }

        public Category GetAllCategoryById(int id)
        {
            return _dbContext.Category.FirstOrDefault(emp => emp.Id == id);
           
        }

        public List<Category> GetAllCategory()
        {

            return _dbContext.Category.ToList();
        }

        public Category UpdateCategory(Category category, int id)
        {
            Category saveBook = GetAllCategoryById(id);

            saveBook.CategoryName = category.CategoryName;
            saveBook.Description = category.Description;
            saveBook.CreatedAt = category.CreatedAt;
            saveBook.Position = category.Position;
            saveBook.Status = category.Status;
            saveBook.Image = category.Image;



            _dbContext.SaveChanges();
            return saveBook;
        }
    }
}
