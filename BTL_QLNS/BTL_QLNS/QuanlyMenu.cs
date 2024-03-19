using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BTL_QLNS.BUS;
namespace BTL_QLNS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        Menu_BUS pbb = new Menu_BUS();
        private void btnExit_Click(object sender, EventArgs e)
        {
            ManHinhChinh frmmch = new ManHinhChinh();
            frmmch.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManHinhChinh frmmch = new ManHinhChinh();
            frmmch.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvPhongban.DataSource = pbb.Search(txtSearch.Text);

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int sonv = 0;
            if (txtMaPB.Text.Trim() == "")
                MessageBox.Show("Mã món không được để trống !");
            else if (txtTenPB.Text.Trim() == "")
                MessageBox.Show("Tên món không được để trống !");
            else
                pbb.insertPB(txtMaPB.Text, txtTenPB.Text, sonv, txtMota.Text);
            Menu_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text.Trim() == "")
                MessageBox.Show("Mã món không được để trống !");
            else if (txtTenPB.Text.Trim() == "")
                MessageBox.Show("Tên món không được để trống !");
            else
            {
                try
                {
                    pbb.updatePB(txtMaPB.Text, txtTenPB.Text, int.Parse(txtSoNV.Text), txtMota.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Giá món phải là kiểu số nguyên !" + ex.Message);
                }
            }
            Menu_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            pbb.deletePB(txtMaPB.Text);
            Menu_Load(sender, e);
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaPB.Text = dgvPhongban.Rows[index].Cells[0].Value.ToString();
                txtTenPB.Text = dgvPhongban.Rows[index].Cells[1].Value.ToString();
                txtSoNV.Text = dgvPhongban.Rows[index].Cells[2].Value.ToString();
                txtMota.Text = dgvPhongban.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            dgvPhongban.DataSource = pbb.getPHONGBAN();
        }
    }
}
