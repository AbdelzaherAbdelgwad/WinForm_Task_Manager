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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginNameTextBox = new TextBox();
            label2 = new Label();
            LoginButton = new Button();
            RegisterButton = new Button();
            label3 = new Label();
            PasswordTextBox = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LoginNameTextBox
            // 
            LoginNameTextBox.Location = new Point(98, 36);
            LoginNameTextBox.Name = "LoginNameTextBox";
            LoginNameTextBox.PlaceholderText = "Enter your name";
            LoginNameTextBox.Size = new Size(186, 23);
            LoginNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 36);
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
            LoginButton.Location = new Point(98, 96);
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
            RegisterButton.Location = new Point(195, 96);
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
            label3.Location = new Point(6, 67);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 7;
            label3.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(98, 67);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderText = "Enter your password";
            PasswordTextBox.Size = new Size(186, 23);
            PasswordTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(PasswordTextBox);
            groupBox1.Controls.Add(RegisterButton);
            groupBox1.Controls.Add(LoginButton);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(LoginNameTextBox);
            groupBox1.Location = new Point(26, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 156);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic Fixed", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(21, -6);
            label1.Name = "label1";
            label1.Size = new Size(100, 33);
            label1.TabIndex = 8;
            label1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(243, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-5, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(375, 275);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "LoginForm";
            Text = "LoginForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private TextBox LoginNameTextBox;
        private Label label2;
        private Button LoginButton;
        private Button RegisterButton;
        private Label label3;
        private TextBox PasswordTextBox;
        private GroupBox groupBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}