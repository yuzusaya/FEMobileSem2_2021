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
    public partial class Page2b : ContentPage
    {
        public Page2b()
        {
            InitializeComponent();
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            TermsAndConditionsCheckbox.IsChecked = !TermsAndConditionsCheckbox.IsChecked;
        }
    }
}