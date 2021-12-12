using FinalExam.Models;
using FinalExam.Views.SetA.Question3;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace FinalExam.ViewModels.SetA
{
    public class Page3aViewModel : BaseViewModel
    {
        private INavigation Navigation;
        private User _currentUser = new User();
        public User CurrentUser { get => _currentUser; set => SetProperty(ref _currentUser, value); }
        public IAsyncCommand GoToNextPageCommand => new AsyncCommand(async () =>
        {
            User newUser = new User()
            {
                ProfileImageSource = CurrentUser.ProfileImageSource,
                Birthday = CurrentUser.Birthday,
                UserName = CurrentUser.UserName,
            };
            await Navigation.PushAsync(new Page4a(newUser));
        }, allowsMultipleExecutions: false);

        public Page3aViewModel()
        {

        }

        public Page3aViewModel(INavigation navigation)
        {
            Navigation = navigation;
            MessagingCenter.Subscribe<Page4aViewModel, User>(this, "ProfileChanged", (sender, args) =>
             {
                 CurrentUser.UserName = args.UserName;
                 CurrentUser.Birthday = args.Birthday;
                 CurrentUser.ImagePath = args.ImagePath;
                 CurrentUser.ProfileImageSource = ImageSource.FromFile(CurrentUser.ImagePath);
             });
        }
    }
}
