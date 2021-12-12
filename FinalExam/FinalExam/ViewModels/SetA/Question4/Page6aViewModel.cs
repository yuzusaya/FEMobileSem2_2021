using FinalExam.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace FinalExam.ViewModels.SetA
{
    public class Page6aViewModel
    {
        private INavigation Navigation;
        public Product CurrentProduct { get; set; }
        public Page6aViewModel()
        {

        }
        public Page6aViewModel(INavigation navigation)
        {
            CurrentProduct = new Product();
            Navigation = navigation;
        }
        public Page6aViewModel(INavigation navigation,Product product)
        {
            CurrentProduct = product;
            Navigation = navigation;
        }

        public IAsyncCommand SaveProductCommand => new AsyncCommand(async () =>
        {
            int count = await App.Database.SaveProductAsync(CurrentProduct);
            if(count > 0)
                await Navigation.PopAsync();
        }, allowsMultipleExecutions: false);
    }
}
