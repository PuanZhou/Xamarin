using prjLottoAPP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace prjLottoAPP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnLotto.Clicked += BtnLotto_Clicked;
        }

        bool hasclick = false;
        private void BtnLotto_Clicked(object sender, EventArgs e)
        {
            hasclick = true;
            if (hasclick)
            {
                btnLotto.Text = "重新生成號碼";
            }   
            lotte.Text= (new CLottoGen()).GetLotto();
        }
    }
}
