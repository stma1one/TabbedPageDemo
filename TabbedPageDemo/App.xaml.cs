using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //To show XAML based tabbed page
            MainPage = new MainPage();

            //To show how to add tabs dynamically
            //MainPage = new DynamicTabbed();
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
