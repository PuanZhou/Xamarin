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

        int num1 = 0, num2 = 0,num3=0;
        
        string op = string.Empty;
        string number = string.Empty;
        private void BtnNumber_Clicked(object sender, EventArgs e)
        {
            if (operatorisClicked ==false)
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
            else if (operatorisClicked == true  &&op=="x" && (addIsClicked == true||subIsClicked==true))
            {
                lblNumber.Text = "";
                number = number + (sender as Button).Text;
                lblNumber.Text = number;
                num3 = Convert.ToInt32(lblNumber.Text);
            }
            else if(operatorisClicked==true)
            {
                lblNumber.Text="";
                number=number+(sender as Button).Text;
                lblNumber.Text = number;
                num2 = Convert.ToInt32(lblNumber.Text);
            }
        }

        bool operatorisClicked = false;

        int count = 0;

        bool addIsClicked = false;
        bool multiIsClicked = false;
        bool subIsClicked = false;

        private void BtnOperator_Clicked(object sender, EventArgs e)
        {
            operatorisClicked = true;
            count++;
            op = (sender as Button).Text;

            number = string.Empty;
            
            if (op == "+")
            {
                addIsClicked = true;
            }

            if (op == "x")
            {
                multiIsClicked = true;
            }

            if (op == "-")
            {
                subIsClicked = true;
            }

            if (count <= 1)
            {
                num1 = Convert.ToInt32(lblNumber.Text);
                lblNumber.Text = num1.ToString();
            }
            else if (operatorisClicked == true && op == "+" && count > 1 && addIsClicked == true && multiIsClicked == true)
            {
                num1 = num1 + (num2 * num3);
                num2 = 0;
                num3 = 0;
                lblNumber.Text = num1.ToString();
            }
            else if (operatorisClicked == true && op == "+" && count > 1 && addIsClicked == true && multiIsClicked == true)
            {
                num1 = num1 + (num2 * num3);
                num2 = 0;
                num3 = 0;
                lblNumber.Text = num1.ToString();
            }
            else if (operatorisClicked == true && op == "-" && count > 1 && subIsClicked == true && multiIsClicked == true)
            {
                num1 = num1 - (num2 * num3);
                num2 = 0;
                num3 = 0;
                lblNumber.Text = num1.ToString();
            }
            else if (operatorisClicked == true && op == "x" && count > 1 && (addIsClicked == true||subIsClicked==true))
            {
            }
            else if (operatorisClicked == true && op == "+"&&count>1)
            {
                num1 = num1 + num2;
                lblNumber.Text = num1.ToString();
            }
            else if (operatorisClicked == true && op == "-" && count > 1)
            {
                num1 = num1 - num2;
                lblNumber.Text = num1.ToString();
            }
            else if (operatorisClicked == true && op == "x" && count > 1)
            {
                num1 = num1 * num2;
                lblNumber.Text = num1.ToString();
            }
        }


        private void BtnResult_Clicked(object sender, EventArgs e)
        {

            if (op == "+")
            {
                lblNumber.Text = (num1 + num2).ToString();
            }
            else if (op == "-")
            {
                lblNumber.Text = (num1 - num2).ToString();
            }
            else if (op == "x" && addIsClicked == true)
            {
                num1 = num1 + (num2 * num3);
                num2 = 0;
                num3 = 0;
                lblNumber.Text = num1.ToString();
            }
            else if (op == "x" && subIsClicked == true)
            {
                num1 = num1 - (num2 * num3);
                num2 = 0;
                num3 = 0;
                lblNumber.Text = num1.ToString();
            }
            else if (op == "x")
            {
                lblNumber.Text = (num1 * num2).ToString();
            }
            else if (op == "/")
            {
                lblNumber.Text = (num1 / num2).ToString();
            }
        }

        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            num3 = 0;
            count = 0;
            operatorisClicked = false;
            addIsClicked = false;
            subIsClicked = false;
            multiIsClicked = false;
            number = string.Empty;
            lblNumber.Text = "0";
        }
    }
}
