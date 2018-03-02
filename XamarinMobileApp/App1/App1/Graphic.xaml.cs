using Microcharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SkiaSharp;


namespace App1
{



    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Graphic : ContentPage
    {



        public Graphic()
        {
            // var z = App.Database.GetItems().ToList();
            //Chart1.BindingContext = z;
            var Pep = App.Database.GetItems().ToList();
            InitializeComponent();
        
       
        }






        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

    } }