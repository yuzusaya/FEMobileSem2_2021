using FinalExam.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FinalExam.ViewModels.SetA
{
    public class Page4aViewModel : BaseViewModel
    {
        private INavigation Navigation;
        public User CurrentUser { get; set; }
        public Page4aViewModel()
        {

        }

        public Page4aViewModel(INavigation navigation,User user)
        {
            Navigation = navigation;
            CurrentUser = user;
        }
        public IAsyncCommand SaveCommand => new AsyncCommand(async () =>
        {
            MessagingCenter.Send(this, "ProfileChanged", CurrentUser);
            await Navigation.PopAsync();
        }, allowsMultipleExecutions: false);

        public IAsyncCommand ChangeProfileCommand => new AsyncCommand(async () =>
        {
            try
            {
                var photo = await MediaPicker.PickPhotoAsync();
                if (photo == null)
                    return;
                var stream = await photo.OpenReadAsync();
                CurrentUser.ProfileImageSource = ImageSource.FromStream(() => stream);
                CurrentUser.ImagePath = photo.FullPath;
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature is not supported on the device
            }
            catch (PermissionException pEx)
            {
                // Permissions not granted
            }
            catch (Exception ex)
            {
            }
        }, allowsMultipleExecutions: false);
    }
}
