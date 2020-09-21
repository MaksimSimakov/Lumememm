using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Xamarin.Forms;

namespace Lumememm
{
    public partial class MainPage : ContentPage
    {
        bool vkl;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void on_Clicked(object sender, EventArgs e)
        {
            {
                lon.Opacity = 1;
                oo.Opacity = 1;
                or.Opacity = 1;
                ot.Opacity = 1;
                await Task.Run(() => Thread.Sleep(3000));


            }
        }

        private void off_Clicked(object sender, EventArgs e)
        {
            lon.Opacity = 0;
            oo.Opacity = 0;
            or.Opacity = 0;
            ot.Opacity = 0;

        }
        Random rnd = new Random();
        private async void Oma_Clicked(object sender, EventArgs e)
        {
            lon.Opacity = 1;
            await Task.Run(() => Thread.Sleep(1000));
            oo.Opacity = 1;
            await Task.Run(() => Thread.Sleep(1000));
            or.Opacity = 1;
            await Task.Run(() => Thread.Sleep(1000));
            ot.Opacity = 1;
            await Task.Run(() => Thread.Sleep(1000));
        }
        Random oma = new Random();
        private void Random_Clicked(object sender, EventArgs e)
        {
            
            {
                int r = rnd.Next(0, 255);
                int g = rnd.Next(0, 255);
                int b = rnd.Next(0, 255);
                lon.BackgroundColor = Color.FromRgb(r, g, b);
                r = rnd.Next(0, 255);
                g = rnd.Next(0, 255);
                b = rnd.Next(0, 255);
                oo.BackgroundColor = Color.FromRgb(r, g, b);
                r = rnd.Next(0, 255);
                g = rnd.Next(0, 255);
                b = rnd.Next(0, 255);
                or.BackgroundColor = Color.FromRgb(r, g, b);
                r = rnd.Next(0, 255);
                g = rnd.Next(0, 255);
                b = rnd.Next(0, 255);
                ot.BackgroundColor = Color.FromRgb(r, g, b);

            }
        }

        private void Oma_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}
