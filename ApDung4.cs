using System;
using System.Drawing;
using System.Windows.Forms;

namespace LeTuanKiet_1150080022_BTtuan5
{
    public class Form6 : Form
    {
        private Label lblMatHang, lblDaChon;
        private ListBox lstMatHang, lstDaChon;
        private Button btnChuyen1, btnChuyenAll, btnTra1, btnTraAll;

        public Form6()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // ===== Form =====
            Text = "Bài tập 7";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(480, 300);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            // ===== Labels =====
            lblMatHang = new Label
            {
                Text = "Danh sách các mặt hàng",
                Location = new Point(20, 15),
                AutoSize = true
            };
            lblDaChon = new Label
            {
                Text = "Các mặt hàng lựa chọn",
                Location = new Point(260, 15),
                AutoSize = true
            };

            Controls.Add(lblMatHang);
            Controls.Add(lblDaChon);

            // ===== ListBoxes =====
            lstMatHang = new ListBox
            {
                Location = new Point(20, 40),
                Size = new Size(180, 200),
                SelectionMode = SelectionMode.MultiExtended
            };
            lstMatHang.Items.AddRange(new object[]
            {
                "CPU","MainBoard","RAM","Keyboard","Mouse","NIC","FAN"
            });

            lstDaChon = new ListBox
            {
                Location = new Point(260, 40),
                Size = new Size(180, 200),
                SelectionMode = SelectionMode.MultiExtended
            };

            Controls.Add(lstMatHang);
            Controls.Add(lstDaChon);

            // ===== Buttons =====
            int bx = 210, by = 60, bw = 40, bh = 30, pad = 40;

            btnChuyen1 = new Button { Text = ">", Location = new Point(bx, by), Size = new Size(bw, bh) };
            btnChuyen1.Click += (s, e) => ChuyenSelected(lstMatHang, lstDaChon);

            btnChuyenAll = new Button { Text = ">>", Location = new Point(bx, by + pad), Size = new Size(bw, bh) };
            btnChuyenAll.Click += (s, e) => ChuyenAll(lstMatHang, lstDaChon);

            btnTra1 = new Button { Text = "<", Location = new Point(bx, by + 2 * pad), Size = new Size(bw, bh) };
            btnTra1.Click += (s, e) => ChuyenSelected(lstDaChon, lstMatHang);

            btnTraAll = new Button { Text = "<<", Location = new Point(bx, by + 3 * pad), Size = new Size(bw, bh) };
            btnTraAll.Click += (s, e) => ChuyenAll(lstDaChon, lstMatHang);

            Controls.AddRange(new Control[] { btnChuyen1, btnChuyenAll, btnTra1, btnTraAll });
        }

        // Chuyển các item được chọn từ src sang dest
        private void ChuyenSelected(ListBox src, ListBox dest)
        {
            var selected = src.SelectedItems;
            // copy ra mảng để tránh lỗi modify khi foreach
            object[] arr = new object[selected.Count];
            selected.CopyTo(arr, 0);
            foreach (var item in arr)
            {
                dest.Items.Add(item);
                src.Items.Remove(item);
            }
        }

        // Chuyển toàn bộ
        private void ChuyenAll(ListBox src, ListBox dest)
        {
            object[] arr = new object[src.Items.Count];
            src.Items.CopyTo(arr, 0);
            dest.Items.AddRange(arr);
            src.Items.Clear();
        }
    }
}
