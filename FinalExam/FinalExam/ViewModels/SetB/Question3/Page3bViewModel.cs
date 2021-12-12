using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FinalExam.ViewModels.SetB
{
    public class Page3bViewModel
    {
        public ICommand TextChangedCommand => new Command<string>((text) =>
        {
            if(text.Length ==6)
            {
                Clipboard.SetTextAsync(text);
            }
        });
    }
}
