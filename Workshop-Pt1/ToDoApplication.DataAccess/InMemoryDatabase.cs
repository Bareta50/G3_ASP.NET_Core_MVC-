using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication.Domain;

namespace ToDoApplication.DataAccess
{
    public static class InMemoryDatabase
    {
        public static List<Category> Categories { get; set; }
        public static List<Status> Statuses { get; set; }
        public static List<ToDo> ToDos { get; set; }

        static InMemoryDatabase()
        {
            LoadCategories();
            LoadStatuses();
            LoadToDos();
        }

        private static void LoadCategories()
        {
            Categories = new List<Category>
            {
                new Category { Id = 1, Name = "Work" },
                new Category { Id = 2, Name = "Health" },
                new Category { Id = 3, Name = "Shopping" },
                new Category { Id = 4, Name = "Finance" },
                new Category { Id = 5, Name = "Education" },
                new Category { Id = 6, Name = "Personal" },
            };
        }

        private static void LoadStatuses()
        {
            Statuses = new List<Status>
            {
                new Status { Id = 1, Name = "In Progress" },
                new Status { Id = 2, Name = "Archived" },
                new Status { Id = 3, Name = "Completed" },
                new Status { Id = 4, Name = "Pending" },
                new Status { Id = 5, Name = "Canceled" },
                new Status { Id = 6, Name = "On Hold" },
            };
        }

        private static void LoadToDos()
        {
            ToDos = new List<ToDo>
            {
                new ToDo()
                {
                    Id = 1,
                    Description = "Complete project report",
                    DueDate = DateTime.Now.AddDays(3),
                    CaegoryId = 1, 
                    StatusId = 4,
                },
                new ToDo()
                {
                    Id = 2,
                    Description = "Grocery shopping",
                    DueDate = DateTime.Now.AddDays(1),
                    CaegoryId = 3, 
                    StatusId = 2,
                },
                new ToDo()
                {
                    Id = 3,
                    Description = "Doctor's appointment",
                    DueDate = DateTime.Now.AddDays(2),
                    CaegoryId = 2, 
                    StatusId = 3,
                },
                new ToDo()
                {
                    Id = 4,
                    Description = "Pay electricity bill",
                    DueDate = DateTime.Now.AddDays(5),
                    CaegoryId = 4, 
                    StatusId = 4,
                },
                new ToDo()
                {
                    Id = 5,
                    Description = "Read a book on personal development",
                    DueDate = DateTime.Now.AddDays(7),
                    CaegoryId = 5, 
                    StatusId = 1,
                },
                new ToDo()
                {
                    Id = 6,
                    Description = "Plan weekend trip",
                    DueDate = DateTime.Now.AddDays(4),
                    CaegoryId = 6, 
                    StatusId = 3,
                },
            };
        }

    }
}
