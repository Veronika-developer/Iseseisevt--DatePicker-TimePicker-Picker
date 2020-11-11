using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iseseisevtoo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new variantKolm();
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
