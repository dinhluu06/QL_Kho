using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_Kho.DT0;
using QL_Kho.BUS;
using QL_Kho.Data;
namespace QL_Kho.Gui
{
    public partial class UC_NCC : UserControl
    {
        public UC_NCC()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            dgvNCC.DataSource = BUS.BUS.xuat_ncc();
        }
        private void NCC_Load(object sender, EventArgs e)
        {
            xuat();
        }
        private void dgvnhaCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maNCC.Text = dgvNCC.CurrentRow.Cells[0].Value.ToString();
            txt_tenNCC.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
           
            txt_diaChi.Text = dgvNCC.CurrentRow.Cells[3].Value.ToString();
            txt_SDT.Text = dgvNCC.CurrentRow.Cells[4].Value.ToString();
            txt_email.Text = dgvNCC.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            NCC a = new NCC();
            a.MaNCC = txt_maNCC.Text.Trim();

            if (BUS.BUS.xoa_NCC(a) != 0)
            {
                MessageBox.Show("xoa thanh cong");
                dgvNCC.DataSource = BUS.BUS.xuat_ncc();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            NCC a = new NCC();
            a.MaNCC = txt_maNCC.Text;
            a.TenNCC = txt_tenNCC.Text;
          
            a.DiaChi = txt_diaChi.Text;
            a.SoDT = txt_SDT.Text;
            a.Email = txt_email.Text;

            if (BUS.BUS.them_ncc(a) != 0)
            {
                MessageBox.Show("Them thanh cong");
                dgvNCC.DataSource = BUS.BUS.xuat_ncc();
            }
           
        }

        private void btnluu_Click(object sender, EventArgs e)
        { 
            txt_maNCC.Text = "";
            txt_tenNCC.Text = "";
            txt_email.Text = "";
            txt_diaChi.Text = "";
            txt_SDT.Text = "";


        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            NCC a = new NCC();
            a.MaNCC = txt_maNCC.Text;
            a.TenNCC = txt_tenNCC.Text;
           
            a.DiaChi = txt_diaChi.Text;
            a.SoDT = txt_SDT.Text;
            a.Email = txt_email.Text;


            if (BUS.BUS.sua_NCC(a) != 0)
            {
                MessageBox.Show("Sua thanh cong");
                dgvNCC.DataSource = BUS.BUS.xuat_ncc();
            }
        }
    }
}
