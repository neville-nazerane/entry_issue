using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Entried
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {

        public IEnumerable<Mainly> Data { get; set; }

        public MainPage()
        {
            Data = new Mainly[] {
                new Mainly
                {
                     Title = "first one",
                     Items = new Mainly[] {
                         new Mainly{
                             Title = "The other one"
                         }
                     }
                }
            };
            BindingContext = Data;
            InitializeComponent();
        }

        public class Mainly
        {

            public string Title { get; set; }

            public IEnumerable<Mainly> Items { get; set; }

        }

    }
} 

