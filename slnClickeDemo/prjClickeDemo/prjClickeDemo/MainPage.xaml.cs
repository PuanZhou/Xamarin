using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace prjClickeDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnEnter_Clicked(object sender, EventArgs e)
        {
   
            double a = Convert.ToDouble(text1.Text);
            double b = Convert.ToDouble(text2.Text);
            double c = Convert.ToDouble(text3.Text);

            double result = Math.Pow(b,2) - 4 * a * c;
            result = Math.Sqrt(result);
            lblAns.Text=$"x={((-b+result)/(2*a)).ToString("0.0#")} OR x={((-b - result) / (2 * a)).ToString("0.0#")}";
        }
    }
}
