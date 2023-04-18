using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Exercise1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            Quotes.Text = quotesArr[0];
            Quotes.TextColor = colorArr[0];
            
        }
        private int index = 0;
        private String[] quotesArr = {"\"Life is like a bicycle. To keep you balance, you must keep moving.\"",
            "\"Anything who has never made a mistake has never tried anything new.\"",
            "\"Try not to become a man of success. Rather become a man of value.\"",
            "\"Logic will get you from A to Z; imagination will get you everywhere.\"", };
        
        private Color[] colorArr = new Color[]
        {
            Color.Black,
            Color.Red,
            Color.Blue,
            Color.Aqua,
            Color.Brown,
            Color.Crimson,
            Color.Pink,
            Color.DarkOrange,
            Color.DarkGreen
        };

        private void Button_Clicked(object sender, EventArgs e)
        {
            index++;
            if(index >= quotesArr.Length) {
                index = 0;
                Quotes.Text = quotesArr[index];
            }
            else
            {
                Quotes.Text = quotesArr[index];
            }

        }

        private void FontColorSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Quotes.TextColor = colorArr[Convert.ToInt32(FontColorSlider.Value)];
        }
    }
}
