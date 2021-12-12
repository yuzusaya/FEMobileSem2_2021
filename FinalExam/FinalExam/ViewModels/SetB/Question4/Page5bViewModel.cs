using FinalExam.Models;
using FinalExam.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace FinalExam.ViewModels.SetB
{
    public class Page5bViewModel
    {
        private INavigation Navigation;
        public PostService ApiService = new PostService();
        public PostRecord CurrentPost { get; set; }
        public Page5bViewModel()
        {

        }
        public Page5bViewModel(INavigation navigation)
        {
            CurrentPost = new PostRecord();
            Navigation = navigation;
        }
        public Page5bViewModel(INavigation navigation, PostRecord record)
        {
            CurrentPost = record;
            Navigation = navigation;
        }

        public IAsyncCommand SaveProductCommand => new AsyncCommand(async () =>
        {
            var success = await ApiService.SavePost(CurrentPost);
            if (success)
                await Navigation.PopAsync();
        }, allowsMultipleExecutions: false);
    }
}
