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
using Xamarin.Forms.Xaml;

namespace FirstApp2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly string helloUrl = "https://reqres.in/api/login";
        public Page1()
        {
            InitializeComponent();
        }
       

        private async void button3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void button4_Clicked(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>() { { "email", EntryName.Text }, { "password", EntryPassword.Text } };

            FormUrlEncodedContent form = new FormUrlEncodedContent(dict);
            HttpResponseMessage response = await client.PostAsync(helloUrl, form);
            string result = await response.Content.ReadAsStringAsync();
            await DisplayAlert("Результат", result, "ok");

            if (result != "{\"error\":\"user not found\"}")
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
    }
}