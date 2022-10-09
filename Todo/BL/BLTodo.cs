using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Interface;
using Todo.Model;

namespace Todo.BL
{
    public class BLTodo : ITodo
    {
        
        public List<TodoModel> GetTodo()
        {

            List<TodoModel> todoList = new List<TodoModel>();
            TodoModel todo = new TodoModel() { Id = 1, Title = "Sample Title", Description = "TodoDescription", Status = "pending" };
            todoList.Add(todo);

            TodoModel todo1 = new TodoModel() { Id = 2, Title = "TitleforTodo", Description = "TodoDescription", Status = "completed" };
            todoList.Add(todo1);

            return todoList;
        }

        public List<TodoModel> UpdateTask(int id, string status)
        {
            List<TodoModel> todoList = GetTodo();
            if (status == "pending")
            {
                todoList.Where(w => w.Id == id).ToList().ForEach(s => s.Status = "completed");

            }
            else
            {
                todoList.Where(w => w.Id == id).ToList().ForEach(s => s.Status = "pending");
            }
            return todoList;
        }

    }
}
