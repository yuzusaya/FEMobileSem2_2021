using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FinalExam.CustomRenderer
{
    public class CustomEntry : Entry
    {
        public static readonly BindableProperty TextChangedCommandProperty =
  BindableProperty.Create(nameof(TextChangedCommand), typeof(ICommand), typeof(CustomEntry), null);
        public ICommand TextChangedCommand
        {
            get { return (ICommand)GetValue(TextChangedCommandProperty); }
            set { SetValue(TextChangedCommandProperty, value); }
        }

        protected override void OnTextChanged(string oldValue, string newValue)
        {
            base.OnTextChanged(oldValue, newValue);
            TextChangedCommand?.Execute(newValue);
        }
    }
}
