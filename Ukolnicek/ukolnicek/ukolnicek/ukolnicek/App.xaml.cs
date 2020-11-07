using System;
using System.IO;
using Xamarin.Forms;
using ukolnicek.Data;

namespace ukolnicek
{
    public partial class App : Application
    {
        static UkolnicekDatabase database;

        public static UkolnicekDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new UkolnicekDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Ukolnicek.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new UkolnicekMainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
