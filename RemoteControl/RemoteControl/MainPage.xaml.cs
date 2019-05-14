using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RemoteControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        public bool flag = true;
        public int r=0, g=0, b=0;

        public MainPage()
        {
            InitializeComponent();
            var tapGesture = new TapGestureRecognizer();

            tapGesture.Tapped += labelClicked;
            label1.GestureRecognizers.Add(tapGesture);

            while (true)
            {
                r += 1;
                g += 1;
                b += 1;

                r= r >= 255 ? 0 : r;
                b = b >= 255 ? 0 : b;
                g = g >= 255 ? 0 : g;


                 
                label1.TextColor = Color.FromRgb(r, g, b);
            }

        }


        private void buttonClicked(object sender, EventArgs args)
        {
            flag = false;
           
            Random generator = new Random();
             r = generator.Next(0, 255);
             g = generator.Next(0, 255);
             b = generator.Next(0, 255);

            label1.TextColor = Color.FromRgb(r, g, b);


        }

        private void RedUpbuttonClicked(object sender, EventArgs args)
        {

            r += 1;

            r = r >= 255 ? 0 : r;
        }
        private void RedDownbuttonClicked(object sender, EventArgs args)
        {

            r -= 1;

            r = r < 0 ? 0 : r;

        }

        private void GreenUpbuttonClicked(object sender, EventArgs args)
        {

            g += 1;

            g = g >= 255 ? 0 : g;
        }
        private void GreenDownbuttonClicked(object sender, EventArgs args)
        {

            g -= 1;

            g = g < 0 ? 0 : g;

        }

        private void BlueUpbuttonClicked(object sender, EventArgs args)
        {

            b += 1;

            b = b >= 255 ? 0 : b;
        }
        private void BlueDownbuttonClicked(object sender, EventArgs args)
        {

            b -= 1;

            b = b < 0 ? 0 : b;

        }

        private void labelClicked(object sender, EventArgs args)
        {
            Random generator = new Random();
            r = generator.Next(0, 255);
            g = generator.Next(0, 255);
            b = generator.Next(0, 255);


            label1.TextColor = Color.FromRgb(r, g, b);

        }
    }
}