
namespace QL_Kho.Gui
{
    partial class UC_HH
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvhangHoa = new System.Windows.Forms.DataGridView();
            this.lbl_mahh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaHH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttenHH = new System.Windows.Forms.TextBox();
            this.txtnhaCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoLuong = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 123);
            this.panel1.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "HÀNG HÓA";
            // 
            // dgvhangHoa
            // 
            this.dgvhangHoa.AllowUserToAddRows = false;
            this.dgvhangHoa.AllowUserToDeleteRows = false;
            this.dgvhangHoa.AllowUserToResizeRows = false;
            this.dgvhangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhangHoa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvhangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhangHoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvhangHoa.Location = new System.Drawing.Point(0, 311);
            this.dgvhangHoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvhangHoa.Name = "dgvhangHoa";
            this.dgvhangHoa.RowHeadersWidth = 51;
            this.dgvhangHoa.RowTemplate.Height = 24;
            this.dgvhangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhangHoa.Size = new System.Drawing.Size(833, 251);
            this.dgvhangHoa.TabIndex = 58;
            this.dgvhangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhangHoa_CellContentClick);
            // 
            // lbl_mahh
            // 
            this.lbl_mahh.AutoSize = true;
            this.lbl_mahh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mahh.Location = new System.Drawing.Point(15, 147);
            this.lbl_mahh.Name = "lbl_mahh";
            this.lbl_mahh.Size = new System.Drawing.Size(68, 20);
            this.lbl_mahh.TabIndex = 59;
            this.lbl_mahh.Text = "Mã HH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Tên HH";
            // 
            // txtmaHH
            // 
            this.txtmaHH.Location = new System.Drawing.Point(89, 145);
            this.txtmaHH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmaHH.Name = "txtmaHH";
            this.txtmaHH.Size = new System.Drawing.Size(189, 22);
            this.txtmaHH.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Nhà CC";
            // 
            // txttenHH
            // 
            this.txttenHH.Location = new System.Drawing.Point(89, 215);
            this.txttenHH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenHH.Name = "txttenHH";
            this.txttenHH.Size = new System.Drawing.Size(189, 22);
            this.txttenHH.TabIndex = 63;
            // 
            // txtnhaCC
            // 
            this.txtnhaCC.Location = new System.Drawing.Point(407, 145);
            this.txtnhaCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnhaCC.Name = "txtnhaCC";
            this.txtnhaCC.Size = new System.Drawing.Size(183, 22);
            this.txtnhaCC.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Số lượng";
            // 
            // txtsoLuong
            // 
            this.txtsoLuong.Location = new System.Drawing.Point(407, 215);
            this.txtsoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsoLuong.Name = "txtsoLuong";
            this.txtsoLuong.Size = new System.Drawing.Size(183, 22);
            this.txtsoLuong.TabIndex = 66;
            this.txtsoLuong.TextChanged += new System.EventHandler(this.txtsoLuong_TextChanged);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(624, 135);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(93, 41);
            this.btnthem.TabIndex = 67;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(725, 135);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(93, 41);
            this.btnsua.TabIndex = 68;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(624, 205);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(93, 41);
            this.btnxoa.TabIndex = 69;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(725, 205);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(93, 41);
            this.btnclear.TabIndex = 70;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // UC_HH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtsoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnhaCC);
            this.Controls.Add(this.txttenHH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmaHH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_mahh);
            this.Controls.Add(this.dgvhangHoa);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_HH";
            this.Size = new System.Drawing.Size(833, 562);
            this.Load += new System.EventHandler(this.HH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvhangHoa;
        private System.Windows.Forms.Label lbl_mahh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaHH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttenHH;
        private System.Windows.Forms.TextBox txtnhaCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoLuong;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnclear;
    }
}
