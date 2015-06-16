namespace QuanLyHocSinh
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGiaoVienDayMon = new System.Windows.Forms.Button();
            this.btnLopHoc = new System.Windows.Forms.Button();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.btnHocVien = new System.Windows.Forms.Button();
            this.btnThoiKhoaBieu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnGiaoVienDayMon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLopHoc, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnKetQua, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGiaoVien, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnHocVien, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnThoiKhoaBieu, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 128);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnGiaoVienDayMon
            // 
            this.btnGiaoVienDayMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoVienDayMon.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoVienDayMon.ForeColor = System.Drawing.Color.Green;
            this.btnGiaoVienDayMon.Location = new System.Drawing.Point(3, 67);
            this.btnGiaoVienDayMon.Name = "btnGiaoVienDayMon";
            this.btnGiaoVienDayMon.Size = new System.Drawing.Size(105, 58);
            this.btnGiaoVienDayMon.TabIndex = 5;
            this.btnGiaoVienDayMon.Text = "Giáo Viên Dạy Môn Học";
            this.btnGiaoVienDayMon.UseVisualStyleBackColor = true;
            this.btnGiaoVienDayMon.Click += new System.EventHandler(this.btnGiaoVienDayMon_Click);
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLopHoc.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopHoc.ForeColor = System.Drawing.Color.Green;
            this.btnLopHoc.Location = new System.Drawing.Point(451, 3);
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.Size = new System.Drawing.Size(105, 58);
            this.btnLopHoc.TabIndex = 4;
            this.btnLopHoc.Text = "Lớp Học";
            this.btnLopHoc.UseVisualStyleBackColor = true;
            this.btnLopHoc.Click += new System.EventHandler(this.btnLopHoc_Click);
            // 
            // btnKetQua
            // 
            this.btnKetQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetQua.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetQua.ForeColor = System.Drawing.Color.Green;
            this.btnKetQua.Location = new System.Drawing.Point(339, 3);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(105, 58);
            this.btnKetQua.TabIndex = 3;
            this.btnKetQua.Text = "Kết Quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(227, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Môn Học";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoVien.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoVien.ForeColor = System.Drawing.Color.Green;
            this.btnGiaoVien.Location = new System.Drawing.Point(115, 3);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(105, 58);
            this.btnGiaoVien.TabIndex = 1;
            this.btnGiaoVien.Text = "Giáo Viên";
            this.btnGiaoVien.UseVisualStyleBackColor = true;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // btnHocVien
            // 
            this.btnHocVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHocVien.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocVien.ForeColor = System.Drawing.Color.Green;
            this.btnHocVien.Location = new System.Drawing.Point(3, 3);
            this.btnHocVien.Name = "btnHocVien";
            this.btnHocVien.Size = new System.Drawing.Size(105, 58);
            this.btnHocVien.TabIndex = 0;
            this.btnHocVien.Text = "Học Viên";
            this.btnHocVien.UseVisualStyleBackColor = true;
            this.btnHocVien.Click += new System.EventHandler(this.btnHocVien_Click);
            // 
            // btnThoiKhoaBieu
            // 
            this.btnThoiKhoaBieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoiKhoaBieu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoiKhoaBieu.ForeColor = System.Drawing.Color.Green;
            this.btnThoiKhoaBieu.Location = new System.Drawing.Point(115, 67);
            this.btnThoiKhoaBieu.Name = "btnThoiKhoaBieu";
            this.btnThoiKhoaBieu.Size = new System.Drawing.Size(105, 58);
            this.btnThoiKhoaBieu.TabIndex = 6;
            this.btnThoiKhoaBieu.Text = "Thời Khóa Biểu";
            this.btnThoiKhoaBieu.UseVisualStyleBackColor = true;
            this.btnThoiKhoaBieu.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 175);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnThoiKhoaBieu;
        private System.Windows.Forms.Button btnGiaoVienDayMon;
        private System.Windows.Forms.Button btnLopHoc;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGiaoVien;
        private System.Windows.Forms.Button btnHocVien;
    }
}

