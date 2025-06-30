using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication.DataAccess.Interfaces;
using ToDoApplication.Domain;

namespace ToDoApplication.DataAccess.Implementations
{
    public class StatusRepo : IRepo<Status>
    {
        public void Add(Status entity)
        {
            InMemoryDatabase.Statuses.Add(entity);
            entity.Id = InMemoryDatabase.Statuses.Count + 1;
        }

        public void Delete(int id)
        {
            var status = GetById(id);
            if (status is not null)
            {
                InMemoryDatabase.Statuses.Remove(status);
            }
        }

        public IEnumerable<Status> GetAll()
        {
            return InMemoryDatabase.Statuses;
        }

        public Status GetById(int id)
        {
            return InMemoryDatabase.Statuses.FirstOrDefault(s => s.Id == id);
        }

        public void Update(Status entity)
        {
            var status = GetById(entity.Id);
            if (status is not null)
            {
                var statusIndex = InMemoryDatabase.Statuses.IndexOf(status);
                InMemoryDatabase.Statuses[statusIndex] = entity;
            }
        }
    }
}
