using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaoSoNgauNhien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random x = new Random();

        /*
         * Hàm tạo số ngẫu nhiên
         */
        
        private int TaoSoNgauNhien(int n)
        {
            int ketqua = 0;

            ketqua = x.Next(n);

            return ketqua;
        }

        /*
         * Tao day ngau nhien
         */

        int[] mangSoNguyenAm;

        private void TaoDayNgauNhien(int n)
        {
            mangSoNguyenAm = new int[n];

            for(int i = 0; i < n ; i++)
            {
                mangSoNguyenAm[i] = TaoSoNgauNhien(n);
            }
        }
        private void btnTinhRanDom_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoNguoiDungNhap.Text);

            TaoDayNgauNhien(n);

           // int xAm 

            for(int i = 0; i < n; i++)
            {
                txtDayNgauNhienAm.Text += " ";

                mangSoNguyenAm[i] = mangSoNguyenAm[i] * -1;

                txtDayNgauNhienAm.Text += mangSoNguyenAm[i].ToString();
            }
     
        }
    }
}
