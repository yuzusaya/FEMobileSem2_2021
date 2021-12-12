using FinalExam.Models;
using FinalExam.ViewModels.SetA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalExam.Views.SetA.Question3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4a : ContentPage
    {
        public Page4a()
        {
            InitializeComponent();
        }
        public Page4a(User user)
        {
            InitializeComponent();
            BindingContext = new Page4aViewModel(Navigation, user);
        }
    }
}