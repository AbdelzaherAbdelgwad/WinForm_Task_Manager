namespace Project_day3
{
    partial class LoginForm
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
            LoginNameTextBox = new TextBox();
            label2 = new Label();
            LoginButton = new Button();
            RegisterButton = new Button();
            label3 = new Label();
            PasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // LoginNameTextBox
            // 
            LoginNameTextBox.Location = new Point(124, 95);
            LoginNameTextBox.Name = "LoginNameTextBox";
            LoginNameTextBox.PlaceholderText = "Enter your name";
            LoginNameTextBox.Size = new Size(186, 23);
            LoginNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(55, 95);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            // 
            // LoginButton
            // 
            LoginButton.FlatAppearance.BorderSize = 4;
            LoginButton.FlatStyle = FlatStyle.System;
            LoginButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LoginButton.Location = new Point(124, 155);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(91, 30);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.FlatAppearance.BorderSize = 4;
            RegisterButton.FlatStyle = FlatStyle.System;
            RegisterButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            RegisterButton.Location = new Point(221, 155);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(89, 30);
            RegisterButton.TabIndex = 5;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 126);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 7;
            label3.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(124, 126);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderText = "Enter your password";
            PasswordTextBox.Size = new Size(186, 23);
            PasswordTextBox.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 301);
            Controls.Add(label3);
            Controls.Add(PasswordTextBox);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
            Controls.Add(label2);
            Controls.Add(LoginNameTextBox);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox LoginNameTextBox;
        private Label label2;
        private Button LoginButton;
        private Button RegisterButton;
        private Label label3;
        private TextBox PasswordTextBox;
    }
}