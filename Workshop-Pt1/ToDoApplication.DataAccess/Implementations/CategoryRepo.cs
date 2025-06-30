using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication.DataAccess.Interfaces;
using ToDoApplication.Domain;


namespace ToDoApplication.DataAccess.Implementations
{
    public class CategoryRepo : IRepo<Category>
    {
        public void Add(Category entity)
        {
            entity.Id = InMemoryDatabase.Categories.Count + 1;
            InMemoryDatabase.Categories.Add(entity);
        }

        public void Delete(int id)
        {
            var category = GetById(id);
            if (category is not null)
            {
                InMemoryDatabase.Categories.Remove(category);
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return InMemoryDatabase.Categories;
        }

        public Category GetById(int id)
        {
            return InMemoryDatabase.Categories.FirstOrDefault(C => C.Id == id);
        }

        public void Update(Category entity)
        {
            var category = GetById(entity.Id);
            if(category is not null)
            {
                var categoryIndex = InMemoryDatabase.Categories.IndexOf(category);
                InMemoryDatabase.Categories[categoryIndex] = entity;
            }
        }
    }
}
