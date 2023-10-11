namespace Otello
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Username = new Label();
            tb_username = new TextBox();
            Password = new Label();
            tb_password = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(96, 67);
            Username.Name = "Username";
            Username.Size = new Size(75, 15);
            Username.TabIndex = 0;
            Username.Text = "Username    :";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(195, 64);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(126, 23);
            tb_username.TabIndex = 1;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(96, 108);
            Password.Name = "Password";
            Password.Size = new Size(75, 15);
            Password.TabIndex = 2;
            Password.Text = "Password     :";
            // 
            // tb_password
            // 
            tb_password.Location = new Point(195, 105);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '●';
            tb_password.Size = new Size(126, 23);
            tb_password.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(130, 149);
            button1.Name = "button1";
            button1.Size = new Size(110, 31);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 203);
            Controls.Add(button1);
            Controls.Add(tb_password);
            Controls.Add(Password);
            Controls.Add(tb_username);
            Controls.Add(Username);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private TextBox tb_username;
        private Label Password;
        private TextBox tb_password;
        private Button button1;
    }
}