using System.Collections.Generic;
using Todo.Model;

namespace Todo.Interface
{
    public interface ITodo
    {
        List<TodoModel> GetTodo();
    }
}
