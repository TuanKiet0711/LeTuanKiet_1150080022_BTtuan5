using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeTuanKiet_1150080022_BTtuan5
{
    public class Form2 : Form
    {
        private GroupBox grpNhapDuLieu;
        private GroupBox grpTuyChon;
        private Label lblA;
        private Label lblB;
        private Label lblKetQua;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtKetQua;
        private RadioButton rdoUSCLN;
        private RadioButton rdoBSCNN;
        private Button btnTim;
        private Button btnThoat;

        public Form2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            grpNhapDuLieu = new GroupBox();
            lblA = new Label();
            txtA = new TextBox();
            lblB = new Label();
            txtB = new TextBox();
            grpTuyChon = new GroupBox();
            rdoUSCLN = new RadioButton();
            rdoBSCNN = new RadioButton();
            lblKetQua = new Label();
            txtKetQua = new TextBox();
            btnTim = new Button();
            btnThoat = new Button();
            grpNhapDuLieu.SuspendLayout();
            grpTuyChon.SuspendLayout();
            SuspendLayout();
            // 
            // grpNhapDuLieu
            // 
            grpNhapDuLieu.BackColor = Color.FromArgb(144, 238, 144);
            grpNhapDuLieu.Controls.Add(lblA);
            grpNhapDuLieu.Controls.Add(txtA);
            grpNhapDuLieu.Controls.Add(lblB);
            grpNhapDuLieu.Controls.Add(txtB);
            grpNhapDuLieu.Font = new Font("Arial", 10F, FontStyle.Bold);
            grpNhapDuLieu.Location = new Point(20, 20);
            grpNhapDuLieu.Name = "grpNhapDuLieu";
            grpNhapDuLieu.Size = new Size(280, 120);
            grpNhapDuLieu.TabIndex = 0;
            grpNhapDuLieu.TabStop = false;
            grpNhapDuLieu.Text = "Nhập dữ liệu:";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.BackColor = Color.Transparent;
            lblA.Font = new Font("Arial", 10F);
            lblA.Location = new Point(20, 35);
            lblA.Name = "lblA";
            lblA.Size = new Size(107, 19);
            lblA.TabIndex = 0;
            lblA.Text = "Số nguyên a:";
            // 
            // txtA
            // 
            txtA.Font = new Font("Arial", 10F);
            txtA.Location = new Point(140, 32);
            txtA.Name = "txtA";
            txtA.Size = new Size(140, 27);
            txtA.TabIndex = 1;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.BackColor = Color.Transparent;
            lblB.Font = new Font("Arial", 10F);
            lblB.Location = new Point(20, 70);
            lblB.Name = "lblB";
            lblB.Size = new Size(107, 19);
            lblB.TabIndex = 2;
            lblB.Text = "Số nguyên b:";
            // 
            // txtB
            // 
            txtB.Font = new Font("Arial", 10F);
            txtB.Location = new Point(140, 65);
            txtB.Name = "txtB";
            txtB.Size = new Size(140, 27);
            txtB.TabIndex = 3;
            // 
            // grpTuyChon
            // 
            grpTuyChon.BackColor = Color.FromArgb(211, 211, 211);
            grpTuyChon.Controls.Add(rdoUSCLN);
            grpTuyChon.Controls.Add(rdoBSCNN);
            grpTuyChon.Font = new Font("Arial", 10F, FontStyle.Bold);
            grpTuyChon.Location = new Point(320, 20);
            grpTuyChon.Name = "grpTuyChon";
            grpTuyChon.Size = new Size(140, 120);
            grpTuyChon.TabIndex = 1;
            grpTuyChon.TabStop = false;
            grpTuyChon.Text = "Tùy chọn:";
            // 
            // rdoUSCLN
            // 
            rdoUSCLN.AutoSize = true;
            rdoUSCLN.BackColor = Color.Transparent;
            rdoUSCLN.Checked = true;
            rdoUSCLN.Font = new Font("Arial", 10F);
            rdoUSCLN.Location = new Point(20, 35);
            rdoUSCLN.Name = "rdoUSCLN";
            rdoUSCLN.Size = new Size(84, 23);
            rdoUSCLN.TabIndex = 0;
            rdoUSCLN.TabStop = true;
            rdoUSCLN.Text = "USCLN";
            rdoUSCLN.UseVisualStyleBackColor = false;
            // 
            // rdoBSCNN
            // 
            rdoBSCNN.AutoSize = true;
            rdoBSCNN.BackColor = Color.Transparent;
            rdoBSCNN.Font = new Font("Arial", 10F);
            rdoBSCNN.Location = new Point(20, 70);
            rdoBSCNN.Name = "rdoBSCNN";
            rdoBSCNN.Size = new Size(86, 23);
            rdoBSCNN.TabIndex = 1;
            rdoBSCNN.Text = "BSCNN";
            rdoBSCNN.UseVisualStyleBackColor = false;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblKetQua.Location = new Point(20, 160);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(76, 19);
            lblKetQua.TabIndex = 2;
            lblKetQua.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            txtKetQua.BackColor = Color.White;
            txtKetQua.Font = new Font("Arial", 10F);
            txtKetQua.Location = new Point(20, 185);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(280, 27);
            txtKetQua.TabIndex = 3;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(173, 216, 230);
            btnTim.Cursor = Cursors.Hand;
            btnTim.FlatStyle = FlatStyle.Popup;
            btnTim.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnTim.Location = new Point(360, 185);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(80, 30);
            btnTim.TabIndex = 4;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 182, 193);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnThoat.Location = new Point(360, 230);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(80, 30);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form2
            // 
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(480, 350);
            Controls.Add(grpNhapDuLieu);
            Controls.Add(grpTuyChon);
            Controls.Add(lblKetQua);
            Controls.Add(txtKetQua);
            Controls.Add(btnTim);
            Controls.Add(btnThoat);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tìm USCLN và BSCNN của số nguyên a và b";
            grpNhapDuLieu.ResumeLayout(false);
            grpNhapDuLieu.PerformLayout();
            grpTuyChon.ResumeLayout(false);
            grpTuyChon.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        // Hàm tính USCLN (Ước số chung lớn nhất)
        private int TinhUSCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Hàm tính BSCNN (Bội số chung nhỏ nhất)
        private int TinhBSCNN(int a, int b)
        {
            if (a == 0 || b == 0) return 0;

            int uscln = TinhUSCLN(a, b);
            return Math.Abs(a * b) / uscln;
        }

        // Hàm kiểm tra và lấy số nguyên từ textbox
        private bool LayGiaTri(out int a, out int b)
        {
            bool hopLe1 = int.TryParse(txtA.Text.Trim(), out a);
            bool hopLe2 = int.TryParse(txtB.Text.Trim(), out b);

            if (!hopLe1 || !hopLe2)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi nhập liệu",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (a == 0 && b == 0)
            {
                MessageBox.Show("Không thể tính USCLN và BSCNN khi cả hai số đều bằng 0!", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Event handler cho button Tìm
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (LayGiaTri(out int a, out int b))
            {
                int ketQua;
                string loaiPhepTinh;

                if (rdoUSCLN.Checked)
                {
                    ketQua = TinhUSCLN(a, b);
                    loaiPhepTinh = "USCLN";
                }
                else
                {
                    ketQua = TinhBSCNN(a, b);
                    loaiPhepTinh = "BSCNN";
                }

                txtKetQua.Text = $"{loaiPhepTinh}({a}, {b}) = {ketQua}";
            }
        }

        // Event handler cho button Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtA.Focus();
        }
    }
}