using Lab12_AMM_Dominguez.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab12_AMM_Dominguez
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TaskView();
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
