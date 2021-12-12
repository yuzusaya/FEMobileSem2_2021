using FinalExam.Models;
using FinalExam.Services;
using FinalExam.Views.SetB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace FinalExam.ViewModels.SetB
{
    public class Page4bViewModel
    {
        private INavigation Navigation;
        public ObservableCollection<PostRecord> PostRecords { get; set; } = new ObservableCollection<PostRecord>();
        public PostService ApiService = new PostService();
        public Page4bViewModel()
        {

        }

        public Page4bViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        public IAsyncCommand FetchPostsCommand => new AsyncCommand(async () =>
        {
            PostRecords.Clear();
            var records = await ApiService.GetAllPosts();
            foreach (var record in records)
            {
                PostRecords.Add(record);
            }
        }, allowsMultipleExecutions: false);
        public IAsyncCommand GoToAddRecordCommand => new AsyncCommand(async () =>
        {
            await Navigation.PushAsync(new Page5b());
        }, allowsMultipleExecutions: false);

        public IAsyncCommand<PostRecord> GoToRecordDetailCommand => new AsyncCommand<PostRecord>(async (record) =>
        {
            await Navigation.PushAsync(new Page5b(record));
        }, allowsMultipleExecutions: false);

        public IAsyncCommand<PostRecord> DeletePostCommand => new AsyncCommand<PostRecord>(async (record) =>
        {
            if (await Application.Current.MainPage.DisplayAlert("", "Are you sure you want to delete?", "Yes", "No"))
            {
                var success = await ApiService.DeletePost(record);
                if (success)
                    PostRecords.Remove(record);
            }
        },allowsMultipleExecutions:false);
    }
}
