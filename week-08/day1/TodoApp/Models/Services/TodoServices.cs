using EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models.Services
{
    public class TodoServices : ITodoServices
    {
        public List<Todo> Todos { get; set; }
        public TodoServices()
        {
            Todos = new List<Todo>();
        }

        public void AddTodo(Todo todo)
        {
            Todos.Add(todo);
        }
        public List<Todo> InitialTodoList()
        {
            Todos.Add(new Todo(1, "Start the day"));
            Todos.Add(new Todo(2, "Finish H2 workshop1"));
            Todos.Add(new Todo(3, "Finish JPA workshop2"));
            Todos.Add(new Todo(4, "Create a CRUD project"));
            return Todos;
        }
    }
}
