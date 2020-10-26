using EntityFramework.Data;
using EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models.Services
{
    public class TodoServices : ITodoServices
    {
        private readonly ApplicationContext dbContext;

        // public List<Todo> Todos { get; set; }
        public TodoServices(ApplicationContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Todo> ReadTodos()
        {
            return dbContext.Todos.ToList();
        }

        public void AddTodo(Todo todo)
        {
            dbContext.Todos.Add(todo);
            dbContext.SaveChanges();
        }
        public void DeleteTodo(long id)
        {
            dbContext.Remove(dbContext.Todos.FirstOrDefault(todo => todo.Id == id));
            dbContext.SaveChanges();
        }
        public List<Todo> InitialTodoList()
        {
            var Todos = new List<Todo>();
            Todos.Add(new Todo(1,"Start the day"));
            Todos.Add(new Todo(2,"Finish H2 workshop1"));
            Todos.Add(new Todo(3,"Finish JPA workshop2"));
            Todos.Add(new Todo(4,"Create a CRUD project"));
            return Todos;
        }
    }
}
