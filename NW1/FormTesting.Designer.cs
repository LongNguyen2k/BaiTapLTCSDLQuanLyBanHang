namespace NW1
{
    partial class FormTesting
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonReload = new System.Windows.Forms.Button();
            this.btLoc = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.buttonJoin = new System.Windows.Forms.Button();
            this.btSapXep = new System.Windows.Forms.Button();
            this.btExecuteSP = new System.Windows.Forms.Button();
            this.gVNhanVIen = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hoTenNhanVienLabel = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVNhanVIen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.gVNhanVIen);
            this.groupBox3.Location = new System.Drawing.Point(97, 210);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(955, 514);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Chung";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonReload);
            this.groupBox2.Controls.Add(this.btLoc);
            this.groupBox2.Controls.Add(this.btTimKiem);
            this.groupBox2.Controls.Add(this.buttonJoin);
            this.groupBox2.Controls.Add(this.btSapXep);
            this.groupBox2.Controls.Add(this.btExecuteSP);
            this.groupBox2.Location = new System.Drawing.Point(96, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(767, 102);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(647, 23);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(100, 71);
            this.buttonReload.TabIndex = 3;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // btLoc
            // 
            this.btLoc.Location = new System.Drawing.Point(529, 23);
            this.btLoc.Margin = new System.Windows.Forms.Padding(4);
            this.btLoc.Name = "btLoc";
            this.btLoc.Size = new System.Drawing.Size(100, 71);
            this.btLoc.TabIndex = 3;
            this.btLoc.Text = "Lọc";
            this.btLoc.UseVisualStyleBackColor = true;
            this.btLoc.Click += new System.EventHandler(this.btLoc_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(420, 23);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(100, 71);
            this.btTimKiem.TabIndex = 2;
            this.btTimKiem.Text = "TimKiem";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // buttonJoin
            // 
            this.buttonJoin.Location = new System.Drawing.Point(195, 23);
            this.buttonJoin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonJoin.Name = "buttonJoin";
            this.buttonJoin.Size = new System.Drawing.Size(100, 71);
            this.buttonJoin.TabIndex = 1;
            this.buttonJoin.Text = "JoinMethod";
            this.buttonJoin.UseVisualStyleBackColor = true;
            this.buttonJoin.Click += new System.EventHandler(this.buttonJoin_Click);
            // 
            // btSapXep
            // 
            this.btSapXep.Location = new System.Drawing.Point(303, 23);
            this.btSapXep.Margin = new System.Windows.Forms.Padding(4);
            this.btSapXep.Name = "btSapXep";
            this.btSapXep.Size = new System.Drawing.Size(100, 71);
            this.btSapXep.TabIndex = 1;
            this.btSapXep.Text = "Sắp Xếp";
            this.btSapXep.UseVisualStyleBackColor = true;
            this.btSapXep.Click += new System.EventHandler(this.btSapXep_Click);
            // 
            // btExecuteSP
            // 
            this.btExecuteSP.Location = new System.Drawing.Point(25, 23);
            this.btExecuteSP.Margin = new System.Windows.Forms.Padding(4);
            this.btExecuteSP.Name = "btExecuteSP";
            this.btExecuteSP.Size = new System.Drawing.Size(142, 71);
            this.btExecuteSP.TabIndex = 0;
            this.btExecuteSP.Text = "ExecuteProcedure";
            this.btExecuteSP.UseVisualStyleBackColor = true;
            this.btExecuteSP.Click += new System.EventHandler(this.btExecuteSP_Click);
            // 
            // gVNhanVIen
            // 
            this.gVNhanVIen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVNhanVIen.Location = new System.Drawing.Point(51, 155);
            this.gVNhanVIen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gVNhanVIen.Name = "gVNhanVIen";
            this.gVNhanVIen.RowHeadersWidth = 62;
            this.gVNhanVIen.RowTemplate.Height = 28;
            this.gVNhanVIen.Size = new System.Drawing.Size(867, 331);
            this.gVNhanVIen.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab);
            this.groupBox1.Controls.Add(this.hoTenNhanVienLabel);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Location = new System.Drawing.Point(83, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(915, 162);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(505, 26);
            this.hoTenNhanVienLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(93, 17);
            this.hoTenNhanVienLabel.TabIndex = 2;
            this.hoTenNhanVienLabel.Text = "Nhập vào tên";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(630, 23);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(265, 22);
            this.txtHoten.TabIndex = 3;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(630, 71);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(265, 22);
            this.txtMaNhanVien.TabIndex = 3;
            this.txtMaNhanVien.TextChanged += new System.EventHandler(this.txtMaNhanVien_TextChanged);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(448, 76);
            this.lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(162, 17);
            this.lab.TabIndex = 2;
            this.lab.Text = "Nhập vào Mã Nhân Viên";
            // 
            // FormTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 737);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormTesting";
            this.Text = "FormTesting";
            this.Load += new System.EventHandler(this.FormTesting_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVNhanVIen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gVNhanVIen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btLoc;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btSapXep;
        private System.Windows.Forms.Button btExecuteSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonJoin;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox txtMaNhanVien;
    }
}