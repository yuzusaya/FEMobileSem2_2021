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
    public partial class Page4b : ContentPage
    {
        Page4bViewModel viewModel;
        public Page4b()
        {
            InitializeComponent();
            BindingContext = viewModel = new Page4bViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel?.FetchPostsCommand.ExecuteAsync();
        }
    }
}