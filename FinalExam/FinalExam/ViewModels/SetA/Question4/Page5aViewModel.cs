using FinalExam.Models;
using FinalExam.Views.SetA.Question4;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace FinalExam.ViewModels.SetA
{
    public class Page5aViewModel
    {
        private INavigation Navigation;
        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();
        public Page5aViewModel()
        {
            
        }

        public Page5aViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        public IAsyncCommand FetchProductsCommand => new AsyncCommand(async () =>
        {
            Products.Clear();
            var products = await App.Database.GetProductsAsync();
            foreach(var product in products)
            {
                Products.Add(product);
            }
        }, allowsMultipleExecutions: false);
        public IAsyncCommand GoToAddProductCommand => new AsyncCommand(async () =>
        {
            await Navigation.PushAsync(new Page6a());
        }, allowsMultipleExecutions: false);
        public IAsyncCommand<Product> GoToProductDetailCommand => new AsyncCommand<Product>(async (product) =>
        {
            await Navigation.PushAsync(new Page6a(product));
        }, allowsMultipleExecutions: false);

        public IAsyncCommand<Product> DeleteProductCommand => new AsyncCommand<Product>(async (product) =>
        {
            if (await Application.Current.MainPage.DisplayAlert("", "Are you sure you want to delete?", "Yes", "No"))
            {
                var count = await App.Database.DeleteProductAsync(product);
                if(count > 0)
                    Products.Remove(product);
            }
        }, allowsMultipleExecutions: false);
    }
}
