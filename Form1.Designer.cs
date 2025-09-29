namespace LeTuanKiet_1150080022_BTtuan5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnXoa = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            btnThoat = new Button();
            txtKetQua = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 117);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập a:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 176);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập b:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 323);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Kết quả:";
            // 
            // txtA
            // 
            txtA.Location = new Point(264, 114);
            txtA.Name = "txtA";
            txtA.Size = new Size(273, 27);
            txtA.TabIndex = 3;
            // 
            // txtB
            // 
            txtB.Location = new Point(264, 173);
            txtB.Name = "txtB";
            txtB.Size = new Size(273, 27);
            txtB.TabIndex = 4;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(73, 251);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(94, 29);
            btnCong.TabIndex = 5;
            btnCong.Text = "Cộng";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += button1_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(274, 251);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(94, 29);
            btnTru.TabIndex = 6;
            btnTru.Text = "Trừ";
            btnTru.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(234, 381);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(483, 251);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(94, 29);
            btnNhan.TabIndex = 8;
            btnNhan.Text = "Nhân";
            btnNhan.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(676, 251);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(94, 29);
            btnChia.TabIndex = 9;
            btnChia.Text = "Chia";
            btnChia.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(427, 381);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(264, 320);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(273, 27);
            txtKetQua.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(57, 24);
            label4.Name = "label4";
            label4.Size = new Size(713, 54);
            label4.TabIndex = 12;
            label4.Text = "THỰC HIỆN CÁC PHÉP TÍNH SỐ HỌC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtKetQua);
            Controls.Add(btnThoat);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnXoa);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtA;
        private TextBox txtB;
        private Button btnCong;
        private Button btnTru;
        private Button btnXoa;
        private Button btnNhan;
        private Button btnChia;
        private Button btnThoat;
        private TextBox txtKetQua;
        private Label label4;
    }
}
