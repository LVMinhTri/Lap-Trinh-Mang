using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Đăng Nhập - LAN Chat";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các ô nhập liệu
                string nickname = txtUser.Text.Trim();
                string ip = txtIP.Text.Trim();
                int port = int.Parse(txtPort.Text.Trim());

                // Bắt lỗi nếu chưa nhập tên
                if (string.IsNullOrEmpty(nickname))
                {
                    MessageBox.Show("Vui lòng nhập Nickname của bạn!");
                    return;
                }

                // Khởi tạo Form Chat và truyền Tên, IP, Port sang đó
                MainChat mainChat = new MainChat(ip, port, nickname);
                mainChat.Show();

                this.Hide(); // Ẩn form đăng nhập
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin IP hoặc Port không hợp lệ! Lỗi: " + ex.Message);
            }
        }
    }
}