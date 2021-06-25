using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace FirstApp2
{
    public partial class MainPage : ContentPage
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly string helloUrl = "https://reqres.in/api/register";
        public MainPage()
        {
            InitializeComponent();
          
        } 
        private async void registration_Clicked(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>() { { "email", EntryName.Text }, { "password", EntryPassword.Text } };

            FormUrlEncodedContent form = new FormUrlEncodedContent(dict);
            HttpResponseMessage response = await client.PostAsync(helloUrl, form);
            string result = await response.Content.ReadAsStringAsync();
            await DisplayAlert("Результат", result, "ok");

            if (result != "{\"error\":\"Note: Only defined users succeed registration\"}")
            {
                if (result != "{\"error\":\"Missing email or username\"}")
                {
                    if (result != "{\"error\":\"Missing password\"}")
                    {
                        await Navigation.PushAsync(new Page2());
                    }
                }
            }
        }

        private async void аuthorization_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}
