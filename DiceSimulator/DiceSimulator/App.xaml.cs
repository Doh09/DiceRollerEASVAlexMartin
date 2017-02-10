using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;
using Xamarin.Forms;

namespace DiceSimulator
{
    public partial class App : Application
    {
        public static IToast MyToast { get; set; }
        public App()
        {
            InitializeComponent();
            
            MainPage = new NavigationPage(new DiceSimulator.DiceRollPage());
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
