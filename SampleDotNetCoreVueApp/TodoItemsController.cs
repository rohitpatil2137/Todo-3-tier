using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class TodoItemsController : ControllerBase
{
    private static readonly List<TodoItem> TodoItems = new List<TodoItem>();

    [HttpGet]
    public ActionResult<IEnumerable<TodoItem>> GetTodoItems()
    {
        return TodoItems;
    }

    [HttpGet("{id}")]
    public ActionResult<TodoItem> GetTodoItem(long id)
    {
        var todoItem = TodoItems.FirstOrDefault(item => item.Id == id);
        if (todoItem == null)
        {
            return NotFound();
        }

        return todoItem;
    }

    [HttpPost]
    public ActionResult<TodoItem> CreateTodoItem(TodoItem todoItem)
    {
        todoItem.Id = TodoItems.Count > 0 ? TodoItems.Max(item => item.Id) + 1 : 1;
        TodoItems.Add(todoItem);
        return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateTodoItem(long id, TodoItem updatedTodoItem)
    {
        var todoItem = TodoItems.FirstOrDefault(item => item.Id == id);
        if (todoItem == null)
        {
            return NotFound();
        }

        todoItem.Title = updatedTodoItem.Title;
        todoItem.IsCompleted = updatedTodoItem.IsCompleted;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteTodoItem(long id)
    {
        var todoItem = TodoItems.FirstOrDefault(item => item.Id == id);
        if (todoItem == null)
        {
            return NotFound();
        }

        TodoItems.Remove(todoItem);
        return NoContent();
    }
}
