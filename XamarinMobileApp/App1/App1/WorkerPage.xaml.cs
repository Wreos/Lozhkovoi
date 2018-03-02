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
	public partial class WorkerPage : ContentPage
	{
        public double zpp = 0;

        public WorkerPage ()
		{
         
            InitializeComponent ();
		}
        private void SaveWorker(object sender, EventArgs e)
        {
            var worker = (Worker)BindingContext;
            if (!String.IsNullOrEmpty(worker.Name)&& !String.IsNullOrEmpty(worker.Family))
            {
                if (worker.Hours > 144)
                {
                    zpp = worker.Hours - 144;
                    worker.Salary = (144 * worker.Tarif)+(zpp*(worker.Tarif)*2);
                    worker.Salaryw = worker.Salary * 0.87;
                    App.Database.SaveItem(worker);
                    DisplayAlert("Подтверждение", "Информация успешно сохранена", "Ок");
                    this.Navigation.PopAsync();
                }
                else
                {
                    worker.Salary = worker.Hours * worker.Tarif;
                    worker.Salaryw = worker.Salary * 0.87;
                    App.Database.SaveItem(worker);
                    DisplayAlert("Подтверждение", "Информация успешно сохранена", "Ок");
                    this.Navigation.PopAsync();
                }
            }
            else
            {
                DisplayAlert("Ошибка", "Вы ввели неверные данные", "Ок");
            }
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
    }
}