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
using QL_Kho.DT0;
namespace QL_Kho.Gui
{
    public partial class UC_Xuat_Hang : UserControl
    {
        public UC_Xuat_Hang()
        {
            InitializeComponent();
        }
        DataTable a = new DataTable();
        private void load()
        {
            DataTable a = new DataTable();
            a = BUS.BUS.xuat_px();
            dgvphieuXuat.DataSource = a;
        }
        private void UC_XuatHang_Load(object sender, EventArgs e)
        {
            load();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            PhieuXuat a = new PhieuXuat();
            a.MaPX = txtma_PX.Text.Trim();
            a.NgayXuat = datePK.Value;

            a.TongTien = float.Parse(txttongTien.Text);

            if (BUS.BUS.them_px(a) != 0)
            {
                MessageBox.Show("Them thanh cong");
                dgvphieuXuat.DataSource = BUS.BUS.xuat_px();
            }
        }

        private void dgvphieuXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma_PX.Text = dgvphieuXuat.CurrentRow.Cells[0].Value.ToString();
            txttongTien.Text = dgvphieuXuat.CurrentRow.Cells[2].Value.ToString();
            datePK.Text = dgvphieuXuat.CurrentRow.Cells[1].Value.ToString();


            dgvCTX.DataSource = BUS.BUS.xuat_ctn(txtma_PX.Text);
        }

        private void dgvCTX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaCTX.Text = dgvCTX.CurrentRow.Cells[0].Value.ToString();
            txtmaHH.Text = dgvCTX.CurrentRow.Cells[1].Value.ToString();
            txtdonGia.Text = dgvCTX.CurrentRow.Cells[3].Value.ToString();
            txt_soLuong.Text = dgvCTX.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            PhieuXuat a = new PhieuXuat();
            a.MaPX = txtma_PX.Text.Trim();
            a.NgayXuat = datePK.Value;

            a.TongTien = float.Parse(txttongTien.Text);

            if (BUS.BUS.sua_PX(a) != 0)
            {
                MessageBox.Show("Sua thanh cong");
                dgvphieuXuat.DataSource = BUS.BUS.xuat_px();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            PhieuXuat a = new PhieuXuat();
            a.MaPX = txtma_PX.Text.Trim();

            if (BUS.BUS.xoa_PX(a) != 0)
            {
                MessageBox.Show("xoa thanh cong");
                dgvphieuXuat.DataSource = BUS.BUS.xuat_px();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            txtma_PX.Text = "";
            txttongTien.Text = "";
        }

        private void btnthem2_Click(object sender, EventArgs e)
        {
            ChiTietXuat a = new ChiTietXuat();
            a.MaPX = txtma_PX.Text.Trim();
            a.MaCTX = txtmaCTX.Text.Trim();
            a.MaCTX = a.MaPX;
            txtmaCTX.Enabled = false;
            a.MaHH = txtmaHH.Text.Trim();
            a.DonGia = float.Parse(txtdonGia.Text);
            a.SoLuong = int.Parse(txt_soLuong.Text);
            if (BUS.BUS.them_ctx(a) != 0)
            {
                MessageBox.Show("Them thanh cong");
                dgvCTX.DataSource = BUS.BUS.xuat_ctx(txtma_PX.Text);
            }
        }

        private void btnsua2_Click(object sender, EventArgs e)
        {
            ChiTietXuat a = new ChiTietXuat();
            a.MaPX = txtma_PX.Text.Trim();
            a.MaCTX = txtmaCTX.Text.Trim();
            a.MaCTX = a.MaPX;
            txtmaCTX.Enabled = false;
            a.MaHH = txtmaHH.Text.Trim();
            a.DonGia = float.Parse(txtdonGia.Text);
            a.SoLuong = int.Parse(txt_soLuong.Text);
            if (BUS.BUS.sua_ctx(a) != 0)
            {
                MessageBox.Show("Sua thanh cong");
                dgvCTX.DataSource = BUS.BUS.xuat_ctx(txtma_PX.Text);
            }
        }

        private void btnxoa2_Click(object sender, EventArgs e)
        {
            ChiTietXuat a = new ChiTietXuat();

            a.MaCTX = txtmaCTX.Text.Trim();

            if (BUS.BUS.xoa_CTX(a) != 0)
            {
                MessageBox.Show("xoa thanh cong");
                dgvCTX.DataSource = BUS.BUS.xuat_ctx(txtma_PX.Text);
            }
            dgvphieuXuat.DataSource = BUS.BUS.xuat_px();
        }

        private void btnluu2_Click(object sender, EventArgs e)
        {
            txtmaCTX.Enabled = true;
            txtmaCTX.Text = "";
            txtmaHH.Text = "";
            txt_soLuong.Text = "";
            txtdonGia.Text = "";
        }
    }
}
