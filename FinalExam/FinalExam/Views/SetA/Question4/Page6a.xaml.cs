using FinalExam.Models;
using FinalExam.ViewModels.SetA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalExam.Views.SetA.Question4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page6a : ContentPage
    {
        public Page6a()
        {
            InitializeComponent();
            BindingContext = new Page6aViewModel(Navigation);
        }

        public Page6a(Product product)
        {
            InitializeComponent();
            BindingContext = new Page6aViewModel(Navigation, product);
        }
    }
}