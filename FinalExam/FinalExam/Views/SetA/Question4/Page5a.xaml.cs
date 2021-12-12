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
    public partial class Page5a : ContentPage
    {
        Page5aViewModel viewModel;
        public Page5a()
        {
            InitializeComponent();
            BindingContext = viewModel = new Page5aViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel?.FetchProductsCommand.ExecuteAsync();
        }
    }
}