using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Todo.BL;
using Todo.Controllers;
using Todo.Interface;
using Todo.Model;
using Xunit;

namespace TodoApi.Test
{
    public class TodoControllerTest
    {
        TodoController _controller;
        ITodo _todo;
        
        public TodoControllerTest()
        {
            _todo = new BLTodo();
            _controller = new TodoController(_todo);
        }
        [Fact]
        public void GetAllTest()
        {
            var result = _controller.Get();

            Assert.IsType<OkObjectResult>(result.Result);

        }
    }
}
