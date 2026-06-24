namespace Client
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
            this.rtbPrivateChat = new System.Windows.Forms.RichTextBox();
            this.txtPrivateMessage = new System.Windows.Forms.TextBox();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.prgFileProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // rtbPrivateChat
            // 
            this.rtbPrivateChat.Location = new System.Drawing.Point(22, 13);
            this.rtbPrivateChat.Name = "rtbPrivateChat";
            this.rtbPrivateChat.ReadOnly = true;
            this.rtbPrivateChat.Size = new System.Drawing.Size(413, 164);
            this.rtbPrivateChat.TabIndex = 0;
            this.rtbPrivateChat.Text = "";
            // 
            // txtPrivateMessage
            // 
            this.txtPrivateMessage.Location = new System.Drawing.Point(22, 200);
            this.txtPrivateMessage.Name = "txtPrivateMessage";
            this.txtPrivateMessage.Size = new System.Drawing.Size(100, 26);
            this.txtPrivateMessage.TabIndex = 1;
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(157, 200);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(101, 32);
            this.btnSendFile.TabIndex = 2;
            this.btnSendFile.Text = "Gửi File ";
            this.btnSendFile.UseVisualStyleBackColor = true;
            // 
            // prgFileProgress
            // 
            this.prgFileProgress.Location = new System.Drawing.Point(306, 200);
            this.prgFileProgress.Name = "prgFileProgress";
            this.prgFileProgress.Size = new System.Drawing.Size(100, 32);
            this.prgFileProgress.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prgFileProgress);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.txtPrivateMessage);
            this.Controls.Add(this.rtbPrivateChat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPrivateChat;
        private System.Windows.Forms.TextBox txtPrivateMessage;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.ProgressBar prgFileProgress;
    }
}