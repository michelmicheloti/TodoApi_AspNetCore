using System;
using System.Collections.Generic;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Tests.Repositories
{
    public class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem todo)
        {

        }

        public IEnumerable<TodoItem> GelAll(string user)
        {
            var model = new List<TodoItem>();
            return model;
        }

        public IEnumerable<TodoItem> GelAllDone(string user)
        {
            var model = new List<TodoItem>();
            return model;
        }

        public IEnumerable<TodoItem> GelAllUndone(string user)
        {
            var model = new List<TodoItem>();
            return model;
        }

        public IEnumerable<TodoItem> GelByPeriod(string user, DateTime date, bool done)
        {
            var model = new List<TodoItem>();
            return model;
        }

        public TodoItem GetById(Guid id, string user)
        {
            return new TodoItem("Titulo","Usuario", DateTime.Now);
        }

        public void Update(TodoItem todo)
        {
            
        }
    }
}