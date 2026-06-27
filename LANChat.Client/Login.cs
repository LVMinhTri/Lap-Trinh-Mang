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
                string nickname = txtUser.Text.Trim();
                string ip = txtIP.Text.Trim();
                int port = int.Parse(txtCong.Text.Trim());

                if (string.IsNullOrEmpty(nickname))
                {
                    MessageBox.Show("Vui lòng nhập Nickname của bạn!");
                    return;
                }

                MainChat mainChat = new MainChat(ip, port, nickname);
                mainChat.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin IP hoặc Port không hợp lệ! Lỗi: " + ex.Message);
            }
        }
    }
}