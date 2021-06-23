using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DoToo.Models;

namespace DoToo.Repositories
{
    public interface ITodoItemRepository
    {
        event EventHandler<TodoItem> OnItemAdded;
        event EventHandler<TodoItem> OnItemUpdate;

        Task<List<TodoItem>> GetItems();
        Task AddItem(TodoItem item);
        Task UpdateItem(TodoItem item);
        Task AddorUpdate(TodoItem item);

    }
}
