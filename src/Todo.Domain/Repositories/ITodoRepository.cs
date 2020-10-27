using System;
using System.Collections.Generic;
using Todo.Domain.Entities;

namespace Todo.Domain.Repositories
{
    public interface ITodoRepository
    {
         void Create(TodoItem todo);
         void Update(TodoItem todo);

         TodoItem GetById(Guid id, string user);

         IEnumerable<TodoItem> GelAll(string user);
         IEnumerable<TodoItem> GelAllDone(string user);
         IEnumerable<TodoItem> GelAllUndone(string user);
         IEnumerable<TodoItem> GelByPeriod(string user, DateTime date, bool done);
    }
}