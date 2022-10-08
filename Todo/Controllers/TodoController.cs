using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Todo.Interface;
using Todo.Model;

namespace Todo.Controllers
{
    [Route("api/Todo")]
    public class TodoController : Controller
    {
       private ITodo todo { get; set; }

        public TodoController(ITodo todo) 
        {
            this.todo = todo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<TodoModel> todoList = todo.GetTodo();
            if(todoList == null) { return NotFound(); }
            return Ok(todoList);
        }
    }
}
