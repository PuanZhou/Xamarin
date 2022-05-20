using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnNumber_Clicked(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(lblNumber.Text);
            if (num == 0)
            {
                lblNumber.Text = (sender as Button).Text;
            }
            else
            {
                lblNumber.Text += (sender as Button).Text;
            }
        }

        int nub1;
        private void BtnOperator_Clicked(object sender, EventArgs e)
        {

            nub1 = Convert.ToInt32(lblNumber.Text);

            op = (sender as Button).Text;

            lblNumber.Text = "0";
        }

        int num2;

        string op = "";


        private void BtnResult_Clicked(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(lblNumber.Text);

            if (op == "+")
            {
                lblNumber.Text = (nub1 + num2).ToString();
            }
            else if (op == "-")
            {
                lblNumber.Text = (nub1 - num2).ToString();
            }
            else if (op == "x")
            {
                lblNumber.Text = (nub1 * num2).ToString();
            }
            else if (op == "/")
            {
                lblNumber.Text = (nub1 / num2).ToString();
            }
        }

        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            nub1 = 0;
            num2 = 0;
            lblNumber.Text = "0";
        }
    }
}
