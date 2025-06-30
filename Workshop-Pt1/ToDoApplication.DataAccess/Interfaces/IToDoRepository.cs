using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication.Domain;

namespace ToDoApplication.DataAccess.Interfaces
{
    public interface IToDoRepository : IRepo<ToDo>
    {
        IEnumerable<ToDo> GetCompleatedToDos();

    }
}
