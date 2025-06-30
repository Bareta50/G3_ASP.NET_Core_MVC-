using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication.DataAccess.Interfaces;
using ToDoApplication.Domain;

namespace ToDoApplication.DataAccess.Implementations
{
    public class ToDoRepo : IToDoRepository
    {
        public void Add(ToDo entity)
        {
            entity.Id = InMemoryDatabase.ToDos.Count + 1;
            InMemoryDatabase.ToDos.Add(entity);
        }

        public void Delete(int id)
        {
            var todo = GetById(id);
            if (todo is not null)
            {
                InMemoryDatabase.ToDos.Remove(todo);
            }
        }

        public IEnumerable<ToDo> GetAll()
        {
            return InMemoryDatabase.ToDos;
        }

        public ToDo GetById(int id)
        {
            return InMemoryDatabase.ToDos.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<ToDo> GetCompleatedToDos()
        {
            return InMemoryDatabase.ToDos.Where(t => t.StatusId == 3).ToList();
        }

        public void Update(ToDo entity)
        {
            var todo = GetById(entity.Id);
            if (todo is not null)
            {
                var todoIndex = InMemoryDatabase.ToDos.IndexOf(todo);
                InMemoryDatabase.ToDos[todoIndex] = entity;
            }
        }
    }
}
