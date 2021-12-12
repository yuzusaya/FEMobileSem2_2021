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
    public partial class Page3a : ContentPage
    {
        public Page3a()
        {
            InitializeComponent();
            BindingContext = new Page3aViewModel(Navigation);
        }
    }
}