using FinalExam.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace FinalExam.Models
{
    public class User : BaseViewModel
    {
        private ImageSource _profileImageSource = ImageSource.FromUri(new Uri("https://cdn.business2community.com/wp-content/uploads/2017/08/blank-profile-picture-973460_640.png"));
        public ImageSource ProfileImageSource { get => _profileImageSource; set => SetProperty(ref _profileImageSource, value); }
        private string _username = "User A";
        public string UserName { get => _username; set => SetProperty(ref _username, value); }
        private DateTime _birthday = new DateTime(2000, 02, 28);
        public DateTime Birthday { get => _birthday; set => SetProperty(ref _birthday, value); }
        public string ImagePath { get; set; }
    }
}
