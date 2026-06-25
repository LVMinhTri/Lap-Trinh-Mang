namespace Client
{
    partial class ChatForm
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
            this.rtbPrivateChat = new System.Windows.Forms.RichTextBox();
            this.txtPrivateMessage = new System.Windows.Forms.TextBox();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstOnlineUsers = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbPrivateChat
            // 
            this.rtbPrivateChat.BackColor = System.Drawing.SystemColors.Window;
            this.rtbPrivateChat.Location = new System.Drawing.Point(22, 64);
            this.rtbPrivateChat.Name = "rtbPrivateChat";
            this.rtbPrivateChat.ReadOnly = true;
            this.rtbPrivateChat.Size = new System.Drawing.Size(714, 311);
            this.rtbPrivateChat.TabIndex = 0;
            this.rtbPrivateChat.Text = "";
            this.rtbPrivateChat.TextChanged += new System.EventHandler(this.rtbPrivateChat_TextChanged);
            // 
            // txtPrivateMessage
            // 
            this.txtPrivateMessage.Location = new System.Drawing.Point(12, 381);
            this.txtPrivateMessage.Name = "txtPrivateMessage";
            this.txtPrivateMessage.Size = new System.Drawing.Size(592, 26);
            this.txtPrivateMessage.TabIndex = 1;
            this.txtPrivateMessage.TextChanged += new System.EventHandler(this.txtPrivateMessage_TextChanged);
            // 
            // btnSendFile
            // 
            this.btnSendFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSendFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendFile.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFile.Location = new System.Drawing.Point(619, 381);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(101, 43);
            this.btnSendFile.TabIndex = 2;
            this.btnSendFile.Text = "Gửi File ";
            this.btnSendFile.UseVisualStyleBackColor = false;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lstOnlineUsers);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnQuaylai);
            this.panel1.Controls.Add(this.txtPrivateMessage);
            this.panel1.Controls.Add(this.btnSendFile);
            this.panel1.Controls.Add(this.rtbPrivateChat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 499);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lstOnlineUsers
            // 
            this.lstOnlineUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstOnlineUsers.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOnlineUsers.FormattingEnabled = true;
            this.lstOnlineUsers.ItemHeight = 23;
            this.lstOnlineUsers.Location = new System.Drawing.Point(791, 64);
            this.lstOnlineUsers.Name = "lstOnlineUsers";
            this.lstOnlineUsers.Size = new System.Drawing.Size(347, 301);
            this.lstOnlineUsers.TabIndex = 6;
            this.lstOnlineUsers.SelectedIndexChanged += new System.EventHandler(this.lstOnlineUsers_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(791, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Gửi ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuaylai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuaylai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaylai.Location = new System.Drawing.Point(22, 12);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(157, 46);
            this.btnQuaylai.TabIndex = 4;
            this.btnQuaylai.Text = "Quay lại ";
            this.btnQuaylai.UseVisualStyleBackColor = false;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 499);
            this.Controls.Add(this.panel1);
            this.Name = "ChatForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPrivateChat;
        private System.Windows.Forms.TextBox txtPrivateMessage;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstOnlineUsers;
    }
}