using DoToo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoToo.ViewModels
{
    class TodoItemViewModels:ViewModel
    {
        public TodoItemViewModels(TodoItem item) => Item = item;

        public event EventHandler ItemStatusChanged;
        public TodoItem Item { get; private set; }
        public string StatusText => Item.Completed ? "Reactivate" : "Completed";

    }
}
