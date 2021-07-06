using System;
using System.Collections.Generic;
using System.Text;
using DoToo.Repositories;
using DoToo.Models;
using Xamarin.Forms;
using System.Windows.Input;

namespace DoToo.ViewModels
{
    public class ItemViewModel : ViewModel
    {
        private readonly TodoItemRepository repository;
        public TodoItem Item { get; set; }

        public ItemViewModel(TodoItemRepository repository)
        {
            this.repository = repository;
            Item = new TodoItem() { Due = DateTime.Now.AddDays(1)};
        }
        public ICommand Save => new Command(async () => {
            await repository.AddorUpdate(Item);
            await Navigation.PopAsync();
        });
    }
}
