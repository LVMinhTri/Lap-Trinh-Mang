using System;
using System.Windows.Forms;

namespace Client
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        // Tự động tắt sạch toàn bộ app khi bấm nút X đỏ của phòng chat
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        // =========================================================
        // CÁC HÀM TRỐNG GIÚP SỬA TRIỆT ĐỂ LỖI THIẾU ĐỊNH NGHĨA (CS1061)
        // =========================================================
        private void ChatForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void lstOnlineUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void rtbPrivateChat_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtPrivateMessage_TextChanged(object sender, EventArgs e)
        {
        }

        // =========================================================
        // CÁC NÚT CHỨC NĂNG CHÍNH CỦA PHÒNG CHAT
        // =========================================================

        // Nút Gửi File
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file để gửi";
            openFileDialog.Filter = "Tất cả các file (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                MessageBox.Show("Bạn đã chọn file: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Nút Quay Lại màn hình đăng nhập
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login(); // Gọi đúng tên Form Login mới đổi của Trâm
            loginForm.Show();
        }
    }
}