using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalExam.Views.SetA.Question2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2a : ContentPage
    {
        public Page2a()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            TermsAndConditionsCheckbox.IsChecked = !TermsAndConditionsCheckbox.IsChecked;
        }
    }
}