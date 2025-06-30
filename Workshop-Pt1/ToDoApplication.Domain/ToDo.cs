using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication.Domain
{
    public class ToDo : BaseEntity
    {
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int CaegoryId { get; set; }
        public Category Category { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
    }
}
