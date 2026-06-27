namespace WindowsFormsApp1
{
    partial class MainChat
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstOnlineUsers = new System.Windows.Forms.ListBox();
            this.btnGui = new System.Windows.Forms.Button();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 381);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(592, 26);
            this.txtMessage.TabIndex = 1;
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
            // 
            // rtbChat
            // 
            this.rtbChat.BackColor = System.Drawing.SystemColors.Window;
            this.rtbChat.Location = new System.Drawing.Point(22, 64);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.Size = new System.Drawing.Size(714, 311);
            this.rtbChat.TabIndex = 0;
            this.rtbChat.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lstOnlineUsers);
            this.panel1.Controls.Add(this.btnGui);
            this.panel1.Controls.Add(this.btnQuaylai);
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Controls.Add(this.btnSendFile);
            this.panel1.Controls.Add(this.rtbChat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 534);
            this.panel1.TabIndex = 5;
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
            // 
            // btnGui
            // 
            this.btnGui.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGui.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.Location = new System.Drawing.Point(791, 381);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(347, 43);
            this.btnGui.TabIndex = 5;
            this.btnGui.Text = "Gửi ";
            this.btnGui.UseVisualStyleBackColor = false;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);

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
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 534);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Phòng Chat Chung";
            //this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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