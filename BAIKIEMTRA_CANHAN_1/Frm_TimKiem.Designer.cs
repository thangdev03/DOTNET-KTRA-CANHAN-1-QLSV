namespace BAIKIEMTRA_CANHAN_1
{
    partial class Frm_TimKiem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.optTimSinhVien = new System.Windows.Forms.RadioButton();
            this.optTimLop = new System.Windows.Forms.RadioButton();
            this.txtSinhVien = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.dtaGridKetQua = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Tìm Kiếm";
            // 
            // optTimSinhVien
            // 
            this.optTimSinhVien.AutoSize = true;
            this.optTimSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.optTimSinhVien.Location = new System.Drawing.Point(79, 80);
            this.optTimSinhVien.Name = "optTimSinhVien";
            this.optTimSinhVien.Size = new System.Drawing.Size(200, 21);
            this.optTimSinhVien.TabIndex = 1;
            this.optTimSinhVien.Text = "Tìm theo thông tin sinh viên";
            this.optTimSinhVien.UseVisualStyleBackColor = true;
            // 
            // optTimLop
            // 
            this.optTimLop.AutoSize = true;
            this.optTimLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.optTimLop.Location = new System.Drawing.Point(79, 112);
            this.optTimLop.Name = "optTimLop";
            this.optTimLop.Size = new System.Drawing.Size(163, 21);
            this.optTimLop.TabIndex = 2;
            this.optTimLop.Text = "Tìm theo thông tin lớp";
            this.optTimLop.UseVisualStyleBackColor = true;
            // 
            // txtSinhVien
            // 
            this.txtSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSinhVien.Location = new System.Drawing.Point(287, 82);
            this.txtSinhVien.Name = "txtSinhVien";
            this.txtSinhVien.Size = new System.Drawing.Size(278, 23);
            this.txtSinhVien.TabIndex = 3;
            // 
            // cboLop
            // 
            this.cboLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboLop.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(287, 112);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(278, 24);
            this.cboLop.TabIndex = 4;
            // 
            // dtaGridKetQua
            // 
            this.dtaGridKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridKetQua.Location = new System.Drawing.Point(79, 167);
            this.dtaGridKetQua.Name = "dtaGridKetQua";
            this.dtaGridKetQua.Size = new System.Drawing.Size(617, 271);
            this.dtaGridKetQua.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(597, 80);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(99, 56);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // Frm_TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dtaGridKetQua);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.txtSinhVien);
            this.Controls.Add(this.optTimLop);
            this.Controls.Add(this.optTimSinhVien);
            this.Controls.Add(this.label1);
            this.Name = "Frm_TimKiem";
            this.Text = "Frm_TimKiem";
            this.Load += new System.EventHandler(this.Frm_TimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optTimSinhVien;
        private System.Windows.Forms.RadioButton optTimLop;
        private System.Windows.Forms.TextBox txtSinhVien;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.DataGridView dtaGridKetQua;
        private System.Windows.Forms.Button btnTimKiem;
    }
}