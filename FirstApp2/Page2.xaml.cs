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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private async void button5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page3Modal());
        }
        private async void button6_Clicked(object sender, EventArgs e)
        {
            // A = Convert.ToString(EntryName.Text)
            //Label.TextProperty = EntryName.TextChanged;
        }
    }
}