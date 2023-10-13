namespace Buoi03_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb1ThongBao = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.mtxtNgaySinh = new System.Windows.Forms.TextBox();
            this.chbTheThao = new System.Windows.Forms.CheckBox();
            this.chbDuLich = new System.Windows.Forms.CheckBox();
            this.chbMuaSam = new System.Windows.Forms.CheckBox();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtDanhSach = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.lb1ThongBao.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(253, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN SINH VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Controls.Add(this.chbMuaSam);
            this.groupBox1.Controls.Add(this.chbDuLich);
            this.groupBox1.Controls.Add(this.chbTheThao);
            this.groupBox1.Controls.Add(this.mtxtNgaySinh);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(62, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(459, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // lb1ThongBao
            // 
            this.lb1ThongBao.Controls.Add(this.txtDanhSach);
            this.lb1ThongBao.Location = new System.Drawing.Point(459, 218);
            this.lb1ThongBao.Name = "lb1ThongBao";
            this.lb1ThongBao.Size = new System.Drawing.Size(302, 205);
            this.lb1ThongBao.TabIndex = 1;
            this.lb1ThongBao.TabStop = false;
            this.lb1ThongBao.Text = "Danh Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sở thích";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(95, 37);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(184, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(95, 79);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(184, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // mtxtNgaySinh
            // 
            this.mtxtNgaySinh.Location = new System.Drawing.Point(95, 119);
            this.mtxtNgaySinh.Name = "mtxtNgaySinh";
            this.mtxtNgaySinh.Size = new System.Drawing.Size(184, 22);
            this.mtxtNgaySinh.TabIndex = 1;
            // 
            // chbTheThao
            // 
            this.chbTheThao.AutoSize = true;
            this.chbTheThao.Location = new System.Drawing.Point(71, 194);
            this.chbTheThao.Name = "chbTheThao";
            this.chbTheThao.Size = new System.Drawing.Size(82, 20);
            this.chbTheThao.TabIndex = 2;
            this.chbTheThao.Text = "Thể thao";
            this.chbTheThao.UseVisualStyleBackColor = true;
            // 
            // chbDuLich
            // 
            this.chbDuLich.AutoSize = true;
            this.chbDuLich.Location = new System.Drawing.Point(71, 220);
            this.chbDuLich.Name = "chbDuLich";
            this.chbDuLich.Size = new System.Drawing.Size(69, 20);
            this.chbDuLich.TabIndex = 2;
            this.chbDuLich.Text = "Du lịch";
            this.chbDuLich.UseVisualStyleBackColor = true;
            // 
            // chbMuaSam
            // 
            this.chbMuaSam.AutoSize = true;
            this.chbMuaSam.Location = new System.Drawing.Point(71, 246);
            this.chbMuaSam.Name = "chbMuaSam";
            this.chbMuaSam.Size = new System.Drawing.Size(84, 20);
            this.chbMuaSam.TabIndex = 2;
            this.chbMuaSam.Text = "Mua sắm";
            this.chbMuaSam.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(95, 151);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(57, 20);
            this.rbNam.TabIndex = 3;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(182, 151);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 20);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm danh sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Xóa ds";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtDanhSach
            // 
            this.txtDanhSach.Location = new System.Drawing.Point(20, 37);
            this.txtDanhSach.Multiline = true;
            this.txtDanhSach.Name = "txtDanhSach";
            this.txtDanhSach.Size = new System.Drawing.Size(264, 146);
            this.txtDanhSach.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb1ThongBao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.lb1ThongBao.ResumeLayout(false);
            this.lb1ThongBao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox lb1ThongBao;
        private System.Windows.Forms.TextBox mtxtNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.CheckBox chbMuaSam;
        private System.Windows.Forms.CheckBox chbDuLich;
        private System.Windows.Forms.CheckBox chbTheThao;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDanhSach;
    }
}

