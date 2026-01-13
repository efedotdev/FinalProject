using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public InMemoryCategoryDal()
        {
            _categories = new List<Category> { 
                new Category {CategoryId=1,CategoryName="Elektronik" }, 
                new Category {CategoryId=2,CategoryName="Beyaz Eşya" } 
            };             
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            Category categoryToDelete = _categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            _categories.Remove(categoryToDelete);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            categoryToUpdate.CategoryName = category.CategoryName;
            categoryToUpdate.CategoryId = category.CategoryId;
        }
    }
}
