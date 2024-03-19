using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTL_QLNS
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }
        private void frm_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void Menu_Click(object sender, EventArgs e)
        {
            DangNhap frmpb = new DangNhap();
            frmpb.Show();
            this.Hide();
        }

        private void btnDuan_Click(object sender, EventArgs e)
        {
            ShowMenu frmda = new ShowMenu();
            frmda.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DangNhap frmdn = new DangNhap();
            frmdn.Show();
            this.Hide();
        }
    }
}
