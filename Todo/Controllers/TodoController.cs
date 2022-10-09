using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Interface;
using Todo.Model;

namespace Todo.Controllers
{
    [Route("api/Todo")]
    public class TodoController : Controller
    {
       private ITodo todo { get; set; }
        private readonly BL.BLTodo updateTask;
    

        public TodoController(ITodo todo, BL.BLTodo updateTask) 
        {
            this.todo = todo;
            this.updateTask = updateTask;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<TodoModel> todoList = todo.GetTodo();
            return Ok(todoList);
        }

        [HttpPut]
        public async Task<IActionResult> put(int id, string status)
        {
            List<TodoModel> todoList = updateTask.UpdateTask(id,status);

            return Ok(todoList);
        }
    }
}
