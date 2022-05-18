using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace prjHelloAPP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SwapColor();
        }

        private void SwapColor()
        {
             string [] colorname = { "紅", "藍", "黃", "綠" };

            Random rng = new Random(Guid.NewGuid().GetHashCode());

            int[] index = { 0, 1, 2, 3 };

            do
            {
                for (int i = index.Length - 1; i > 0; i--)
                {
                    int j = rng.Next(i + 1);
                    int temp = index[i];
                    index[i] = index[j];
                    index[j] = temp;
                }

                red.Text = colorname[index[0]];

                blue.Text = colorname[index[1]];

                yellow.Text = colorname[index[2]];

                green.Text = colorname[index[3]];
            }
            while (red.Text == "紅" || blue.Text == "藍" || yellow.Text == "黃" || green.Text == "綠");
        }
    }
}
