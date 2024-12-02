using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CreditApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userLine.Text) || string.IsNullOrWhiteSpace(passLine.Text))
            {
                await DisplayAlert("Ошибка", "Пожалуйста, заполните все поля.", "OK");
            }
            else
            {
                string name = userLine.Text;
                await Navigation.PushModalAsync(new NavigationPage(new TabbedPage1(name)));
            }
        }

       
    }
}
