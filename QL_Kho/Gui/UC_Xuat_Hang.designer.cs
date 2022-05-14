
namespace QL_Kho.Gui
{
    partial class UC_Xuat_Hang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvphieuXuat = new System.Windows.Forms.DataGridView();
            this.dgvCTX = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtmaPN = new System.Windows.Forms.Label();
            this.txtma_PX = new System.Windows.Forms.TextBox();
            this.txtngayLap = new System.Windows.Forms.Label();
            this.datePK = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txttongTien = new System.Windows.Forms.TextBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.MCTN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DG = new System.Windows.Forms.Label();
            this.txtsoLuong = new System.Windows.Forms.Label();
            this.txtmaCTX = new System.Windows.Forms.TextBox();
            this.txtmaHH = new System.Windows.Forms.TextBox();
            this.txtdonGia = new System.Windows.Forms.TextBox();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.btnthem2 = new System.Windows.Forms.Button();
            this.btnsua2 = new System.Windows.Forms.Button();
            this.btnxoa2 = new System.Windows.Forms.Button();
            this.btnluu2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 89);
            this.panel1.TabIndex = 44;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "XUẤT HÀNG";
            // 
            // dgvphieuXuat
            // 
            this.dgvphieuXuat.AllowUserToAddRows = false;
            this.dgvphieuXuat.AllowUserToDeleteRows = false;
            this.dgvphieuXuat.AllowUserToResizeRows = false;
            this.dgvphieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvphieuXuat.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvphieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphieuXuat.Location = new System.Drawing.Point(4, 337);
            this.dgvphieuXuat.Margin = new System.Windows.Forms.Padding(4);
            this.dgvphieuXuat.Name = "dgvphieuXuat";
            this.dgvphieuXuat.ReadOnly = true;
            this.dgvphieuXuat.RowHeadersWidth = 51;
            this.dgvphieuXuat.Size = new System.Drawing.Size(427, 144);
            this.dgvphieuXuat.TabIndex = 64;
            this.dgvphieuXuat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphieuXuat_CellContentClick);
            // 
            // dgvCTX
            // 
            this.dgvCTX.AllowUserToAddRows = false;
            this.dgvCTX.AllowUserToDeleteRows = false;
            this.dgvCTX.AllowUserToResizeRows = false;
            this.dgvCTX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTX.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCTX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTX.Location = new System.Drawing.Point(431, 337);
            this.dgvCTX.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCTX.Name = "dgvCTX";
            this.dgvCTX.ReadOnly = true;
            this.dgvCTX.RowHeadersWidth = 51;
            this.dgvCTX.Size = new System.Drawing.Size(421, 144);
            this.dgvCTX.TabIndex = 65;
            this.dgvCTX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTX_CellContentClick);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(4, 271);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(91, 44);
            this.btnthem.TabIndex = 66;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtmaPN
            // 
            this.txtmaPN.AutoSize = true;
            this.txtmaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaPN.Location = new System.Drawing.Point(27, 109);
            this.txtmaPN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtmaPN.Name = "txtmaPN";
            this.txtmaPN.Size = new System.Drawing.Size(113, 17);
            this.txtmaPN.TabIndex = 67;
            this.txtmaPN.Text = "Mã Phiếu Xuất";
            // 
            // txtma_PX
            // 
            this.txtma_PX.Location = new System.Drawing.Point(167, 107);
            this.txtma_PX.Margin = new System.Windows.Forms.Padding(4);
            this.txtma_PX.Multiline = true;
            this.txtma_PX.Name = "txtma_PX";
            this.txtma_PX.Size = new System.Drawing.Size(175, 24);
            this.txtma_PX.TabIndex = 68;
            // 
            // txtngayLap
            // 
            this.txtngayLap.AutoSize = true;
            this.txtngayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngayLap.Location = new System.Drawing.Point(40, 163);
            this.txtngayLap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtngayLap.Name = "txtngayLap";
            this.txtngayLap.Size = new System.Drawing.Size(83, 17);
            this.txtngayLap.TabIndex = 69;
            this.txtngayLap.Text = "Ngày Xuất";
            // 
            // datePK
            // 
            this.datePK.Location = new System.Drawing.Point(167, 159);
            this.datePK.Margin = new System.Windows.Forms.Padding(4);
            this.datePK.Name = "datePK";
            this.datePK.Size = new System.Drawing.Size(175, 22);
            this.datePK.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "Tổng Tiền";
            // 
            // txttongTien
            // 
            this.txttongTien.Location = new System.Drawing.Point(167, 212);
            this.txttongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txttongTien.Multiline = true;
            this.txttongTien.Name = "txttongTien";
            this.txttongTien.Size = new System.Drawing.Size(172, 24);
            this.txttongTien.TabIndex = 72;
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(103, 271);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(93, 44);
            this.btnsua.TabIndex = 73;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(204, 271);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(93, 44);
            this.btnxoa.TabIndex = 74;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(305, 271);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(93, 44);
            this.btnluu.TabIndex = 75;
            this.btnluu.Text = "Clr";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // MCTN
            // 
            this.MCTN.AutoSize = true;
            this.MCTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCTN.Location = new System.Drawing.Point(438, 109);
            this.MCTN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MCTN.Name = "MCTN";
            this.MCTN.Size = new System.Drawing.Size(128, 17);
            this.MCTN.TabIndex = 76;
            this.MCTN.Text = "Mã Chi Tiết Xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "Mã Hàng Hóa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DG
            // 
            this.DG.AutoSize = true;
            this.DG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DG.Location = new System.Drawing.Point(463, 214);
            this.DG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(67, 17);
            this.DG.TabIndex = 78;
            this.DG.Text = "Đơn Giá";
            // 
            // txtsoLuong
            // 
            this.txtsoLuong.AutoSize = true;
            this.txtsoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoLuong.Location = new System.Drawing.Point(461, 271);
            this.txtsoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtsoLuong.Name = "txtsoLuong";
            this.txtsoLuong.Size = new System.Drawing.Size(77, 17);
            this.txtsoLuong.TabIndex = 79;
            this.txtsoLuong.Text = "Số Lượng";
            // 
            // txtmaCTX
            // 
            this.txtmaCTX.Location = new System.Drawing.Point(593, 105);
            this.txtmaCTX.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaCTX.Multiline = true;
            this.txtmaCTX.Name = "txtmaCTX";
            this.txtmaCTX.Size = new System.Drawing.Size(140, 26);
            this.txtmaCTX.TabIndex = 80;
            // 
            // txtmaHH
            // 
            this.txtmaHH.Location = new System.Drawing.Point(593, 157);
            this.txtmaHH.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaHH.Multiline = true;
            this.txtmaHH.Name = "txtmaHH";
            this.txtmaHH.Size = new System.Drawing.Size(140, 24);
            this.txtmaHH.TabIndex = 81;
            // 
            // txtdonGia
            // 
            this.txtdonGia.Location = new System.Drawing.Point(593, 207);
            this.txtdonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtdonGia.Multiline = true;
            this.txtdonGia.Name = "txtdonGia";
            this.txtdonGia.Size = new System.Drawing.Size(140, 24);
            this.txtdonGia.TabIndex = 82;
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(593, 264);
            this.txt_soLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soLuong.Multiline = true;
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(140, 24);
            this.txt_soLuong.TabIndex = 83;
            // 
            // btnthem2
            // 
            this.btnthem2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnthem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem2.Location = new System.Drawing.Point(761, 97);
            this.btnthem2.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem2.Name = "btnthem2";
            this.btnthem2.Size = new System.Drawing.Size(91, 44);
            this.btnthem2.TabIndex = 84;
            this.btnthem2.Text = "Thêm2";
            this.btnthem2.UseVisualStyleBackColor = false;
            this.btnthem2.Click += new System.EventHandler(this.btnthem2_Click);
            // 
            // btnsua2
            // 
            this.btnsua2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsua2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua2.Location = new System.Drawing.Point(759, 149);
            this.btnsua2.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua2.Name = "btnsua2";
            this.btnsua2.Size = new System.Drawing.Size(93, 44);
            this.btnsua2.TabIndex = 85;
            this.btnsua2.Text = "Sửa2";
            this.btnsua2.UseVisualStyleBackColor = false;
            this.btnsua2.Click += new System.EventHandler(this.btnsua2_Click);
            // 
            // btnxoa2
            // 
            this.btnxoa2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnxoa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa2.Location = new System.Drawing.Point(759, 201);
            this.btnxoa2.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa2.Name = "btnxoa2";
            this.btnxoa2.Size = new System.Drawing.Size(93, 44);
            this.btnxoa2.TabIndex = 86;
            this.btnxoa2.Text = "Xóa2";
            this.btnxoa2.UseVisualStyleBackColor = false;
            this.btnxoa2.Click += new System.EventHandler(this.btnxoa2_Click);
            // 
            // btnluu2
            // 
            this.btnluu2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnluu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu2.Location = new System.Drawing.Point(759, 252);
            this.btnluu2.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu2.Name = "btnluu2";
            this.btnluu2.Size = new System.Drawing.Size(93, 44);
            this.btnluu2.TabIndex = 87;
            this.btnluu2.Text = "Clr";
            this.btnluu2.UseVisualStyleBackColor = false;
            this.btnluu2.Click += new System.EventHandler(this.btnluu2_Click);
            // 
            // UC_Xuat_Hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnluu2);
            this.Controls.Add(this.btnxoa2);
            this.Controls.Add(this.btnsua2);
            this.Controls.Add(this.btnthem2);
            this.Controls.Add(this.txt_soLuong);
            this.Controls.Add(this.txtdonGia);
            this.Controls.Add(this.txtmaHH);
            this.Controls.Add(this.txtmaCTX);
            this.Controls.Add(this.txtsoLuong);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MCTN);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.txttongTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datePK);
            this.Controls.Add(this.txtngayLap);
            this.Controls.Add(this.txtma_PX);
            this.Controls.Add(this.txtmaPN);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvCTX);
            this.Controls.Add(this.dgvphieuXuat);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Xuat_Hang";
            this.Size = new System.Drawing.Size(856, 485);
            this.Load += new System.EventHandler(this.UC_XuatHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvphieuXuat;
        private System.Windows.Forms.DataGridView dgvCTX;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label txtmaPN;
        private System.Windows.Forms.TextBox txtma_PX;
        private System.Windows.Forms.Label txtngayLap;
        private System.Windows.Forms.DateTimePicker datePK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttongTien;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label MCTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DG;
        private System.Windows.Forms.Label txtsoLuong;
        private System.Windows.Forms.TextBox txtmaCTX;
        private System.Windows.Forms.TextBox txtmaHH;
        private System.Windows.Forms.TextBox txtdonGia;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.Button btnthem2;
        private System.Windows.Forms.Button btnsua2;
        private System.Windows.Forms.Button btnxoa2;
        private System.Windows.Forms.Button btnluu2;
    }
}
