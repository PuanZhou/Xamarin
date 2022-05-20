using prjOrderApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace prjOrderApp
{
    public partial class MainPage : ContentPage
    {
        List<C票券> list = new List<C票券>();
        public MainPage()
        {
            InitializeComponent();
            LoadData();
        }

        int index=0;
        private void LoadData()
        {
            list.Add(new C票券() { 場次 = "阿凡達 II", 座位 = "8E", 日期 = "2022/08/03 12:00:00", 票券編號 = 1, 票種 = "敬老票" });
            list.Add(new C票券() { 場次 = "奇異博士2", 座位 = "8J", 日期 = "2022/06/05 13:20:00", 票券編號 = 1, 票種 = "愛心票" });
            list.Add(new C票券() { 場次 = "奇異博士2", 座位 = "7E", 日期 = "2022/06/05 9:30:00", 票券編號 = 1, 票種 = "學生票" });
            list.Add(new C票券() { 場次 = "天能", 座位 = "12C", 日期 = "2022/05/25 18:30:00", 票券編號 = 1, 票種 = "成人票" });
            list.Add(new C票券() { 場次 = "全面啟動", 座位 = "3B", 日期 = "2022/06/13 18:30:00", 票券編號 = 1, 票種 = "成人票" });
            list.Add(new C票券() { 場次 = "星際效應", 座位 = "8H", 日期 = "2022/06/05 19:00:00", 票券編號 = 1, 票種 = "成人票" });
            list.Add(new C票券() { 場次 = "月昇冒險王國", 座位 = "9A", 日期 = "2022/06/06 11:30:00", 票券編號 = 1, 票種 = "兒童票" });

            txtDate.Text = list[0].日期;
            txtId.Text = list[0].票券編號.ToString();
            txtSeat.Text = list[0].座位;
            txt場次.Text = list[0].場次;
            txt票種.Text = list[0].票種;

        }

        private void btnFirst_Clicked(object sender, EventArgs e)
        {
            index = 0;
            txtDate.Text = list[0].日期;
            txtId.Text = list[0].票券編號.ToString();
            txtSeat.Text = list[0].座位;
            txt場次.Text = list[0].場次;
            txt票種.Text = list[0].票種;
        }

        private void btnlast_Clicked(object sender, EventArgs e)
        {

            index = list.Count - 1;

            txtDate.Text = list[list.Count-1].日期;
            txtId.Text = list[list.Count-1].票券編號.ToString();
            txtSeat.Text = list[list.Count-1].座位;
            txt場次.Text = list[list.Count-1].場次;
            txt票種.Text = list[list.Count-1].票種;
        }

        private void btnPrevious_Clicked(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                txtDate.Text = list[index].日期;
                txtId.Text = list[index].票券編號.ToString();
                txtSeat.Text = list[index].座位;
                txt場次.Text = list[index].場次;
                txt票種.Text = list[index].票種;
            }
            else
            {
                return;
            }
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            if (index < list.Count-1)
            {
                index++;
                txtDate.Text = list[index].日期;
                txtId.Text = list[index].票券編號.ToString();
                txtSeat.Text = list[index].座位;
                txt場次.Text = list[index].場次;
                txt票種.Text = list[index].票種;
            }
            else
            {
                return;
            }
        }
    }
}
