using System.Collections.Generic;
using System;
using System.Threading.Tasks;

public class TodosService
{
    public async Task<IEnumerable<TodoItem>> GetTodoItems(){
        

        var items = new List<TodoItem>
        {
            new TodoItem { Title= "Blazor uitzoeken", Content = "Best een vet framework eigenlijk", DueDate = DateTime.Now.AddDays(1), IsDone = true },
            new TodoItem { Title= "Op een dino jagen", Content = "Vrij weinig content", DueDate = DateTime.Now.AddDays(2), IsDone = true },
            new TodoItem { Title= "Presentatie geven", Content = "En wel eentje die zijn weerga niet kent!", DueDate = DateTime.Now.AddDays(1), IsDone = false },
            new TodoItem { Title= "World Domination", Content = "Getting closer every day", DueDate = DateTime.Now.AddDays(5), IsDone = false }
        };

        return items;
    }

}
