using DoToo.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using DoToo.Views;

namespace DoToo.ViewModels
{
    public  class MainViewModel : ViewModel
    {
        private readonly TodoItemRepository repository;

        public MainViewModel(TodoItemRepository repository)
        {
            this.repository = repository;
            Task.Run(async () => await LoadData());
        }
        public ICommand AddItem => new Command(async () => {
           var itemView = Resolver.Resolve<ItemView>();
            await Navigation.PushAsync(itemView);
        });
        private async Task LoadData()
        { 
        
        }
    }
}
