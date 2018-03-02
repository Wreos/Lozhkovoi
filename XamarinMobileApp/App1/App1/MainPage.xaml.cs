using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {



        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            workersList.ItemsSource = App.Database.GetItems();

          
            base.OnAppearing();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Worker selectedWorker = (Worker)e.SelectedItem;
            WorkerPage workerPage = new WorkerPage();
            workerPage.BindingContext = selectedWorker;
            await Navigation.PushAsync(workerPage);
        }
        private async void CreateWorker(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            WorkerPage workerPage = new WorkerPage();
           
            workerPage.BindingContext = worker;
            await Navigation.PushAsync(workerPage);
        }

       async void MakeGraph(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new Graphic());
        }
    }
}