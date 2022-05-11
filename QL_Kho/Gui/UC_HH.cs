using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_Kho.BUS;
using QL_Kho.Data;
using QL_Kho.DT0;
namespace QL_Kho.Gui
{
    public partial class UC_HH : UserControl
    {
        public UC_HH()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            dgvhangHoa.DataSource = BUS.BUS.xuat_hh();
        }
        private void HH_Load(object sender, EventArgs e)
        {
            xuat();
        }

        private void txtsoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HangHoa a = new HangHoa();
            a.MaHH = txtmaHH.Text;
            a.TenHH = txttenHH.Text;
            a.MaNCC = txtnhaCC.Text;
            a.SoLuong = txtsoLuong.Text;


            if (BUS.BUS.sua_HH(a) != 0)
            {
                MessageBox.Show("Sua thanh cong");
                dgvhangHoa.DataSource = BUS.BUS.xuat_hh();
            }

        }

        private void dgvhangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaHH.Text = dgvhangHoa.CurrentRow.Cells[0].Value.ToString();
            txttenHH.Text = dgvhangHoa.CurrentRow.Cells[1].Value.ToString();
            txtnhaCC.Text = dgvhangHoa.CurrentRow.Cells[2].Value.ToString();
            txtsoLuong.Text = dgvhangHoa.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            HangHoa a = new HangHoa();
            a.MaHH = txtmaHH.Text;
            a.TenHH = txttenHH.Text;
            a.MaNCC = txtnhaCC.Text;
            a.SoLuong = txtsoLuong.Text;



            if (BUS.BUS.them_hh(a) != 0)
            {
                MessageBox.Show("Them thanh cong");
                dgvhangHoa.DataSource = BUS.BUS.xuat_hh();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            HangHoa a = new HangHoa();
            a.MaHH = txtmaHH.Text.Trim();

            if (BUS.BUS.xoa_HH(a) != 0)
            {
                MessageBox.Show("xoa thanh cong");
                dgvhangHoa.DataSource = BUS.BUS.xuat_hh();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmaHH.Text = "";
            txtnhaCC.Text = "";
            txtsoLuong.Text = "";
            txttenHH.Text="";
        }
    }
}
