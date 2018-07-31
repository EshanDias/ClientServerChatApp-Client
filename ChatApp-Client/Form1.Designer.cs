namespace ChatApp_Client
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
            this.lb_onlineUsers = new System.Windows.Forms.ListBox();
            this.rtb_chatArea = new System.Windows.Forms.RichTextBox();
            this.lb_chatHistory = new System.Windows.Forms.ListBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.lbl_friendsName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_onlineUsers
            // 
            this.lb_onlineUsers.FormattingEnabled = true;
            this.lb_onlineUsers.Location = new System.Drawing.Point(744, 12);
            this.lb_onlineUsers.Name = "lb_onlineUsers";
            this.lb_onlineUsers.Size = new System.Drawing.Size(238, 394);
            this.lb_onlineUsers.TabIndex = 0;
            // 
            // rtb_chatArea
            // 
            this.rtb_chatArea.Location = new System.Drawing.Point(12, 310);
            this.rtb_chatArea.Name = "rtb_chatArea";
            this.rtb_chatArea.Size = new System.Drawing.Size(614, 96);
            this.rtb_chatArea.TabIndex = 1;
            this.rtb_chatArea.Text = "";
            // 
            // lb_chatHistory
            // 
            this.lb_chatHistory.FormattingEnabled = true;
            this.lb_chatHistory.Location = new System.Drawing.Point(12, 64);
            this.lb_chatHistory.Name = "lb_chatHistory";
            this.lb_chatHistory.Size = new System.Drawing.Size(614, 225);
            this.lb_chatHistory.TabIndex = 2;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(650, 361);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(650, 332);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // lbl_friendsName
            // 
            this.lbl_friendsName.AutoSize = true;
            this.lbl_friendsName.Location = new System.Drawing.Point(13, 23);
            this.lbl_friendsName.Name = "lbl_friendsName";
            this.lbl_friendsName.Size = new System.Drawing.Size(74, 13);
            this.lbl_friendsName.TabIndex = 5;
            this.lbl_friendsName.Text = "Friend\'s Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 421);
            this.Controls.Add(this.lbl_friendsName);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lb_chatHistory);
            this.Controls.Add(this.rtb_chatArea);
            this.Controls.Add(this.lb_onlineUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_onlineUsers;
        private System.Windows.Forms.RichTextBox rtb_chatArea;
        private System.Windows.Forms.ListBox lb_chatHistory;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lbl_friendsName;
    }
}

