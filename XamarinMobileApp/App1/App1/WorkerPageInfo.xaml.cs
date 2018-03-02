using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkerPageInfo : ContentPage
    {
        public WorkerPageInfo()
        {
            
            InitializeComponent();
        }

        private void DeleteWorker(object sender, EventArgs e)
        {
            var worker = (Worker)BindingContext;
            App.Database.DeleteItem(worker.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
        private async void EditWorker(object sender, SelectedItemChangedEventArgs e)
        {
            Worker selectedWorker = (Worker)e.SelectedItem;
            WorkerPage workerPage = new WorkerPage();
            workerPage.BindingContext = selectedWorker;
            await Navigation.PushAsync(workerPage);
        }

        private async void Show(object sender, EventArgs e)
        {
            await DisplayAlert("Контекстное меню", "Пункт Show", "OK");
        }
    }
}
