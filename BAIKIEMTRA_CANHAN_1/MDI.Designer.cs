namespace BAIKIEMTRA_CANHAN_1
{
    partial class MDI
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
            this.btnDMLop = new System.Windows.Forms.Button();
            this.btnKhoaVien = new System.Windows.Forms.Button();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDMLop
            // 
            this.btnDMLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDMLop.Location = new System.Drawing.Point(123, 157);
            this.btnDMLop.Name = "btnDMLop";
            this.btnDMLop.Size = new System.Drawing.Size(111, 57);
            this.btnDMLop.TabIndex = 0;
            this.btnDMLop.Text = "DM Lớp";
            this.btnDMLop.UseVisualStyleBackColor = true;
            this.btnDMLop.Click += new System.EventHandler(this.btnDMLop_Click);
            // 
            // btnKhoaVien
            // 
            this.btnKhoaVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoaVien.Location = new System.Drawing.Point(259, 157);
            this.btnKhoaVien.Name = "btnKhoaVien";
            this.btnKhoaVien.Size = new System.Drawing.Size(111, 57);
            this.btnKhoaVien.TabIndex = 0;
            this.btnKhoaVien.Text = "Khoa Viện";
            this.btnKhoaVien.UseVisualStyleBackColor = true;
            this.btnKhoaVien.Click += new System.EventHandler(this.btnKhoaVien_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhVien.Location = new System.Drawing.Point(395, 157);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(111, 57);
            this.btnSinhVien.TabIndex = 0;
            this.btnSinhVien.Text = "Sinh viên";
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(531, 157);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(111, 57);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(319, 263);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(111, 39);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnSinhVien);
            this.Controls.Add(this.btnKhoaVien);
            this.Controls.Add(this.btnDMLop);
            this.Name = "MDI";
            this.Text = "MDI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDMLop;
        private System.Windows.Forms.Button btnKhoaVien;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLogOut;
    }
}