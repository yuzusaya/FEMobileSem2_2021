using FinalExam.Models;
using FinalExam.ViewModels.SetB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalExam.Views.SetB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page5b : ContentPage
    {
        public Page5b()
        {
            InitializeComponent();
            BindingContext = new Page5bViewModel(Navigation);
        }

        public Page5b(PostRecord record)
        {
            InitializeComponent();
            BindingContext = new Page5bViewModel(Navigation,record);
        }
    }
}