using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategory();
        Category AddCategory(Category category);
        int DeleteCategory(int categoryid);

        Category GetCategoryByCategoryId(int id);
        int UpdateCategory(int id,Category category);
    }
}
