using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Boca_danut_lab12.Data;


namespace Boca_danut_lab12
{
    public partial class App : Application
    {


        public static ShoppingListDatabase Database { get; private set; }


        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
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
