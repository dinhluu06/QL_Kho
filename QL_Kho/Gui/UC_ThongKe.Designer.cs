﻿namespace QL_Kho.Gui
{
    partial class UC_ThongKe
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
            this.dgvtkhh = new System.Windows.Forms.DataGridView();
            this.rdb_hh = new System.Windows.Forms.RadioButton();
            this.rdb_nhap = new System.Windows.Forms.RadioButton();
            this.rdb_xuat = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtkhh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 129);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ HÀNG HÓA";
            // 
            // dgvtkhh
            // 
            this.dgvtkhh.AllowUserToAddRows = false;
            this.dgvtkhh.AllowUserToDeleteRows = false;
            this.dgvtkhh.AllowUserToResizeRows = false;
            this.dgvtkhh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtkhh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtkhh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvtkhh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtkhh.Location = new System.Drawing.Point(0, 217);
            this.dgvtkhh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvtkhh.Name = "dgvtkhh";
            this.dgvtkhh.RowHeadersWidth = 51;
            this.dgvtkhh.RowTemplate.Height = 24;
            this.dgvtkhh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtkhh.Size = new System.Drawing.Size(916, 273);
            this.dgvtkhh.TabIndex = 46;
            // 
            // rdb_hh
            // 
            this.rdb_hh.AutoSize = true;
            this.rdb_hh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_hh.Location = new System.Drawing.Point(125, 162);
            this.rdb_hh.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_hh.Name = "rdb_hh";
            this.rdb_hh.Size = new System.Drawing.Size(110, 26);
            this.rdb_hh.TabIndex = 47;
            this.rdb_hh.TabStop = true;
            this.rdb_hh.Text = "Hàng hóa";
            this.rdb_hh.UseVisualStyleBackColor = true;
            this.rdb_hh.CheckedChanged += new System.EventHandler(this.rdb_hh_CheckedChanged);
            // 
            // rdb_nhap
            // 
            this.rdb_nhap.AutoSize = true;
            this.rdb_nhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_nhap.Location = new System.Drawing.Point(335, 162);
            this.rdb_nhap.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_nhap.Name = "rdb_nhap";
            this.rdb_nhap.Size = new System.Drawing.Size(155, 26);
            this.rdb_nhap.TabIndex = 48;
            this.rdb_nhap.TabStop = true;
            this.rdb_nhap.Text = "Hàng hóa nhập";
            this.rdb_nhap.UseVisualStyleBackColor = true;
            this.rdb_nhap.CheckedChanged += new System.EventHandler(this.rdb_nhap_CheckedChanged);
            // 
            // rdb_xuat
            // 
            this.rdb_xuat.AutoSize = true;
            this.rdb_xuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_xuat.Location = new System.Drawing.Point(561, 162);
            this.rdb_xuat.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_xuat.Name = "rdb_xuat";
            this.rdb_xuat.Size = new System.Drawing.Size(150, 26);
            this.rdb_xuat.TabIndex = 49;
            this.rdb_xuat.TabStop = true;
            this.rdb_xuat.Text = "Hàng hóa xuất";
            this.rdb_xuat.UseVisualStyleBackColor = true;
            this.rdb_xuat.CheckedChanged += new System.EventHandler(this.rdb_xuat_CheckedChanged);
            // 
            // UC_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rdb_xuat);
            this.Controls.Add(this.rdb_nhap);
            this.Controls.Add(this.rdb_hh);
            this.Controls.Add(this.dgvtkhh);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(920, 494);
            this.Load += new System.EventHandler(this.UC_ThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtkhh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvtkhh;
        private System.Windows.Forms.RadioButton rdb_hh;
        private System.Windows.Forms.RadioButton rdb_nhap;
        private System.Windows.Forms.RadioButton rdb_xuat;
    }
}
