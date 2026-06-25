using System;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập Nickname của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtIP.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ IP Server!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIP.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtCong.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập cổng kết nối (Port)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCong.Focus();
                return;
            }

            ChatForm chatForm = new ChatForm();
            chatForm.Show();
            this.Hide();
        }
    }
}