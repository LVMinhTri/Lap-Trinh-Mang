namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.txtCong = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtIPServer = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.BackColor = System.Drawing.Color.AliceBlue;
            this.btnKetNoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetNoi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetNoi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnKetNoi.Location = new System.Drawing.Point(119, 334);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(576, 55);
            this.btnKetNoi.TabIndex = 28;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.UseVisualStyleBackColor = false;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // txtCong
            // 
            this.txtCong.Location = new System.Drawing.Point(257, 273);
            this.txtCong.Name = "txtCong";
            this.txtCong.Size = new System.Drawing.Size(277, 26);
            this.txtCong.TabIndex = 27;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(257, 214);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(277, 26);
            this.txtIP.TabIndex = 26;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(257, 154);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(277, 26);
            this.txtUser.TabIndex = 25;
            // 
            // txtIPServer
            // 
            this.txtIPServer.AutoSize = true;
            this.txtIPServer.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPServer.Location = new System.Drawing.Point(115, 214);
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.Size = new System.Drawing.Size(90, 23);
            this.txtIPServer.TabIndex = 24;
            this.txtIPServer.Text = "IP Server";
            // 
            // txtPort
            // 
            this.txtPort.AutoSize = true;
            this.txtPort.BackColor = System.Drawing.Color.Transparent;
            this.txtPort.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(115, 276);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(47, 23);
            this.txtPort.TabIndex = 23;
            this.txtPort.Text = "Port";
            // 
            // txtNickname
            // 
            this.txtNickname.AutoSize = true;
            this.txtNickname.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNickname.Location = new System.Drawing.Point(115, 155);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(94, 23);
            this.txtNickname.TabIndex = 22;
            this.txtNickname.Text = "Nickname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(93, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 41);
            this.label1.TabIndex = 21;
            this.label1.Text = "CHÀO MỪNG ĐẾN VỚI LAN CHAT ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.txtCong);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtIPServer);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Đăng nhập - LAN Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.TextBox txtCong;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label txtIPServer;
        private System.Windows.Forms.Label txtPort;
        private System.Windows.Forms.Label txtNickname;
        private System.Windows.Forms.Label label1;
    }
}

