namespace Apiwithentity.Model
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategory();
        Category AddCategory(Category category);
        void DeleteCategory(int id);
        Category GetAllCategoryById(int id);
        Category UpdateCategory(Category category, int id);
    }
}
