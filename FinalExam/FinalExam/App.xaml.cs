using FinalExam.Services;
using FinalExam.Views;
using FinalExam.Views.SetA.Question1;
using FinalExam.Views.SetA.Question2;
using FinalExam.Views.SetA.Question3;
using FinalExam.Views.SetA.Question4;
using FinalExam.Views.SetB;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalExam
{
    public partial class App : Application
    {
        static ProductDatabase database;

        // Create the database connection as a singleton.
        public static ProductDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ProductDatabase();
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new NavigationPage(new Page4b());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
