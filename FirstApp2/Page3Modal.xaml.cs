using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApp2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3Modal : ContentPage
    {
        public Page3Modal()
        {
            InitializeComponent();
        }

        private async void button6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}