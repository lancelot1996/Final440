using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Final440
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedulePage : ContentPage
    {
        static int clickTotal;
        public SchedulePage()
        {
            InitializeComponent();
        }
        async void OnButtonairplaneClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AirportPage());
        }
    }


}



