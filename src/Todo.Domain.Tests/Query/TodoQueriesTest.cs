using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.Query
{
    [TestClass]
    public class TodoQueriesTest
    {
        private List<TodoItem> _items;

        public TodoQueriesTest()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", "Usuario1", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 2", "Usuario2", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 3", "Usuario3", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 4", "Usuario4", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 5", "Usuario1", DateTime.Now));
        }

        [TestMethod]
        public void Dado_uma_consulta_deve_retornar_apenas_do_usuario1()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("Usuario1"));
            Assert.AreEqual(2, result.Count());
        }
    }
}