using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;

namespace Todo.Domain.Tests.Entities
{
    [TestClass]
    public class TodoItemTests
    {
        private readonly TodoItem _validTodo = new TodoItem("Titulo", "Usuaraio", DateTime.Now);

         [TestMethod]
        public void Dado_um_novo_todo_ele_nao_deve_ser_concluido()
        {
            Assert.AreEqual(_validTodo.Done, false);
        }
    }
}