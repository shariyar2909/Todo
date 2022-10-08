using System.Collections.Generic;
using Todo.Interface;
using Todo.Model;

namespace Todo.BL
{
    public class BLTodo : ITodo
    {
        public List<TodoModel> GetTodo()
        {
            List<TodoModel> todoList = new List<TodoModel>();

            TodoModel todo = new TodoModel() {Id = 1, Title = "TitleforTodo", Description = "TodoDescription", Status = "pending" };
            todoList.Add(todo);

            return todoList;
        }
    }
}
