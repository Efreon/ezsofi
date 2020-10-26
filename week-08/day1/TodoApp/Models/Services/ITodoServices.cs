using EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models.Services
{
    public interface ITodoServices
    {
        void AddTodo(Todo todo);
        List<Todo> InitialTodoList();
        List<Todo> ReadTodos();
        void DeleteTodo(long id);
    }
}
