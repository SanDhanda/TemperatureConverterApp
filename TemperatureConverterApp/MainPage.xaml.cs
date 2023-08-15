using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TemperatureConverterApp
{
    
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Convert(object sender, System.EventArgs e)
        {
            decimal value = decimal.Parse(degreesValue.Text);
            String type = typePicker.SelectedItem.ToString();
            decimal result = 0;
            if(type == "Celcius")
            {
                decimal val = 5m / 9m;
                result = (value - 32) * val;
            }
            else
            {
                decimal val = 9m / 5m;
                result = (value * val) + 32;
            }
            ResultEntry.Text = result.ToString();
        }

        
    }
    
}
