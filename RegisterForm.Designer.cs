namespace Project_day3
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label3 = new Label();
            PasswordTextBox = new TextBox();
            RegisterButton = new Button();
            label2 = new Label();
            NameTextBox = new TextBox();
            label1 = new Label();
            EmailTextBox = new TextBox();
            label4 = new Label();
            ConfirmPasswordTextBox = new TextBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(77, 96);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 13;
            label3.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(173, 97);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderText = "Enter your password";
            PasswordTextBox.Size = new Size(186, 23);
            PasswordTextBox.TabIndex = 12;
            // 
            // RegisterButton
            // 
            RegisterButton.FlatAppearance.BorderSize = 4;
            RegisterButton.FlatStyle = FlatStyle.System;
            RegisterButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            RegisterButton.Location = new Point(200, 175);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(125, 30);
            RegisterButton.TabIndex = 11;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(104, 31);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 9;
            label2.Text = "Name:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(173, 31);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Enter your name";
            NameTextBox.Size = new Size(186, 23);
            NameTextBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(104, 63);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 15;
            label1.Text = "Email:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(173, 63);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.PlaceholderText = "Enter your Email";
            EmailTextBox.Size = new Size(186, 23);
            EmailTextBox.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 134);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 17;
            label4.Text = "Confirm password:";
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Location = new Point(173, 135);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.PasswordChar = '*';
            ConfirmPasswordTextBox.PlaceholderText = "Confirm your pasword";
            ConfirmPasswordTextBox.Size = new Size(186, 23);
            ConfirmPasswordTextBox.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ConfirmPasswordTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(EmailTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(PasswordTextBox);
            groupBox1.Controls.Add(RegisterButton);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(NameTextBox);
            groupBox1.Location = new Point(35, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 225);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Simplified Arabic Fixed", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(17, -5);
            label5.Name = "label5";
            label5.Size = new Size(236, 33);
            label5.TabIndex = 19;
            label5.Text = "Register form";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(340, 183);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(474, 306);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "RegisterForm";
            Text = "RegisterForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private TextBox PasswordTextBox;
        private Button RegisterButton;
        private Label label2;
        private TextBox NameTextBox;
        private Label label1;
        private TextBox EmailTextBox;
        private Label label4;
        private TextBox ConfirmPasswordTextBox;
        private GroupBox groupBox1;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}