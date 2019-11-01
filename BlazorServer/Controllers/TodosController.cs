using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
namespace BlazorServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : Controller
    {
        [HttpGet]
        public IEnumerable<TodoItem> GetTodoItems(){
            
            return new List<TodoItem>
            {
                new TodoItem { Title= "title 1", Content = "content 1", DueDate = DateTime.Now.AddDays(1), IsDone = false },
                new TodoItem { Title= "title 2", Content = "content 2", DueDate = DateTime.Now.AddDays(2), IsDone = false }
            };
        }

    }
}