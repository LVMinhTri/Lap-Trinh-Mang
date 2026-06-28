namespace WindowsFormsApp1
{
    partial class MainChat
    {
        /// Required designer variable.
        private System.ComponentModel.IContainer components = null;

        /// Clean up any resources being used.
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

        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        private void InitializeComponent()
        {
            txtMessage = new TextBox();
            btnSendFile = new Button();
            rtbChat = new RichTextBox();
            panel1 = new Panel();
            lstOnlineUsers = new ListBox();
            btnGui = new Button();
            btnQuaylai = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 381);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(592, 31);
            txtMessage.TabIndex = 1;
            // 
            // btnSendFile
            // 
            btnSendFile.BackColor = SystemColors.ActiveCaption;
            btnSendFile.FlatStyle = FlatStyle.Flat;
            btnSendFile.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendFile.Location = new Point(619, 381);
            btnSendFile.Name = "btnSendFile";
            btnSendFile.Size = new Size(101, 43);
            btnSendFile.TabIndex = 2;
            btnSendFile.Text = "Gửi File ";
            btnSendFile.UseVisualStyleBackColor = false;
            btnSendFile.Click += btnSendFile_Click;
            // 
            // rtbChat
            // 
            rtbChat.BackColor = SystemColors.Window;
            rtbChat.Location = new Point(22, 64);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(714, 311);
            rtbChat.TabIndex = 0;
            rtbChat.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(lstOnlineUsers);
            panel1.Controls.Add(btnGui);
            panel1.Controls.Add(btnQuaylai);
            panel1.Controls.Add(txtMessage);
            panel1.Controls.Add(btnSendFile);
            panel1.Controls.Add(rtbChat);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1201, 534);
            panel1.TabIndex = 5;
            // 
            // lstOnlineUsers
            // 
            lstOnlineUsers.BorderStyle = BorderStyle.FixedSingle;
            lstOnlineUsers.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstOnlineUsers.FormattingEnabled = true;
            lstOnlineUsers.ItemHeight = 23;
            lstOnlineUsers.Location = new Point(791, 64);
            lstOnlineUsers.Name = "lstOnlineUsers";
            lstOnlineUsers.Size = new Size(347, 301);
            lstOnlineUsers.TabIndex = 6;
            // 
            // btnGui
            // 
            btnGui.BackColor = SystemColors.ActiveCaption;
            btnGui.FlatStyle = FlatStyle.Flat;
            btnGui.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGui.Location = new Point(791, 381);
            btnGui.Name = "btnGui";
            btnGui.Size = new Size(347, 43);
            btnGui.TabIndex = 5;
            btnGui.Text = "Gửi ";
            btnGui.UseVisualStyleBackColor = false;
            btnGui.Click += btnGui_Click;
            // 
            // btnQuaylai
            // 
            btnQuaylai.BackColor = SystemColors.ActiveCaption;
            btnQuaylai.FlatStyle = FlatStyle.Flat;
            btnQuaylai.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuaylai.Location = new Point(22, 12);
            btnQuaylai.Name = "btnQuaylai";
            btnQuaylai.Size = new Size(157, 46);
            btnQuaylai.TabIndex = 4;
            btnQuaylai.Text = "Quay lại ";
            btnQuaylai.UseVisualStyleBackColor = false;
            btnQuaylai.Click += btnQuaylai_Click;
            // 
            // MainChat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 534);
            Controls.Add(panel1);
            Name = "MainChat";
            Text = "Phòng Chat Chung";
            FormClosing += MainChat_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstOnlineUsers;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button btnQuaylai;
    }
}