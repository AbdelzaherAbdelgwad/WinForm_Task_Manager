namespace Project_day3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            SearchBarTextBox = new TextBox();
            FilterComboBox = new ComboBox();
            label1 = new Label();
            CreateOrEditLabel = new Label();
            TitleTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            PiriorityComboBox = new ComboBox();
            StatusComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            pictureBox5 = new PictureBox();
            DueDatePicker = new Project_day3.CustomControls.CustomDatePicker();
            CancelButton = new Button();
            EditButton = new Button();
            label8 = new Label();
            CategoryComboBox = new ComboBox();
            CreateTaskButton = new Button();
            UsernameLabel = new Label();
            label2 = new Label();
            SortByComboBox = new ComboBox();
            notifyIcon1 = new NotifyIcon(components);
            NextPageButton = new Project_day3.CustomControls.CustomButton();
            PreviousPageButton = new Project_day3.CustomControls.CustomButton();
            dataGridView1 = new Project_day3.CustomControls.CustomGridView();
            LogoutButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            groupBox2 = new GroupBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // SearchBarTextBox
            // 
            SearchBarTextBox.BackColor = SystemColors.Menu;
            SearchBarTextBox.Location = new Point(9, 51);
            SearchBarTextBox.Name = "SearchBarTextBox";
            SearchBarTextBox.PlaceholderText = "Search for Tasks";
            SearchBarTextBox.Size = new Size(420, 23);
            SearchBarTextBox.TabIndex = 0;
            SearchBarTextBox.TextChanged += HandleSearchChange;
            // 
            // FilterComboBox
            // 
            FilterComboBox.BackColor = SystemColors.Menu;
            FilterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterComboBox.FlatStyle = FlatStyle.Popup;
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Items.AddRange(new object[] { "-- No filter --", "Pending", "InProgress", "Completed" });
            FilterComboBox.Location = new Point(531, 54);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(121, 23);
            FilterComboBox.TabIndex = 2;
            FilterComboBox.SelectedIndexChanged += HandleFilterDataChange;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(473, 57);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 3;
            label1.Text = "Filter by:";
            // 
            // CreateOrEditLabel
            // 
            CreateOrEditLabel.AutoSize = true;
            CreateOrEditLabel.Font = new Font("Simplified Arabic Fixed", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CreateOrEditLabel.Location = new Point(35, -5);
            CreateOrEditLabel.Name = "CreateOrEditLabel";
            CreateOrEditLabel.Size = new Size(270, 33);
            CreateOrEditLabel.TabIndex = 4;
            CreateOrEditLabel.Text = "Create New Task";
            // 
            // TitleTextBox
            // 
            TitleTextBox.BackColor = SystemColors.Menu;
            TitleTextBox.Location = new Point(105, 49);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(200, 23);
            TitleTextBox.TabIndex = 5;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.BackColor = SystemColors.Menu;
            DescriptionTextBox.Location = new Point(105, 95);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(200, 94);
            DescriptionTextBox.TabIndex = 6;
            // 
            // PiriorityComboBox
            // 
            PiriorityComboBox.BackColor = SystemColors.Menu;
            PiriorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PiriorityComboBox.FlatStyle = FlatStyle.Popup;
            PiriorityComboBox.FormattingEnabled = true;
            PiriorityComboBox.Items.AddRange(new object[] { "Low", "Medium", "High" });
            PiriorityComboBox.Location = new Point(105, 255);
            PiriorityComboBox.Name = "PiriorityComboBox";
            PiriorityComboBox.Size = new Size(200, 23);
            PiriorityComboBox.TabIndex = 8;
            // 
            // StatusComboBox
            // 
            StatusComboBox.BackColor = SystemColors.Menu;
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.FlatStyle = FlatStyle.Popup;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Items.AddRange(new object[] { "Pending", "InProgress", "Completed" });
            StatusComboBox.Location = new Point(105, 301);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(200, 23);
            StatusComboBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(57, 49);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 10;
            label3.Text = "Title:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 94);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 11;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 213);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 12;
            label5.Text = "Due date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(31, 255);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 13;
            label6.Text = "Piriority:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(45, 300);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 14;
            label7.Text = "Status:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(DueDatePicker);
            groupBox1.Controls.Add(CancelButton);
            groupBox1.Controls.Add(EditButton);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(CategoryComboBox);
            groupBox1.Controls.Add(CreateTaskButton);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(StatusComboBox);
            groupBox1.Controls.Add(PiriorityComboBox);
            groupBox1.Controls.Add(DescriptionTextBox);
            groupBox1.Controls.Add(TitleTextBox);
            groupBox1.Controls.Add(CreateOrEditLabel);
            groupBox1.Location = new Point(721, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 466);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-18, 410);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            // 
            // DueDatePicker
            // 
            DueDatePicker.CalendarMonthBackground = SystemColors.Menu;
            DueDatePicker.Location = new Point(105, 213);
            DueDatePicker.Name = "DueDatePicker";
            DueDatePicker.Size = new Size(200, 23);
            DueDatePicker.TabIndex = 23;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Red;
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.Enabled = false;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CancelButton.ForeColor = SystemColors.ButtonHighlight;
            CancelButton.Location = new Point(208, 414);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(97, 36);
            CancelButton.TabIndex = 19;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.LightGray;
            EditButton.Cursor = Cursors.Hand;
            EditButton.Enabled = false;
            EditButton.FlatStyle = FlatStyle.Popup;
            EditButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            EditButton.Location = new Point(208, 373);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(97, 36);
            EditButton.TabIndex = 18;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(27, 347);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 17;
            label8.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.BackColor = SystemColors.Menu;
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FlatStyle = FlatStyle.Popup;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(105, 344);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(200, 23);
            CategoryComboBox.TabIndex = 16;
            // 
            // CreateTaskButton
            // 
            CreateTaskButton.BackColor = Color.LightGray;
            CreateTaskButton.Cursor = Cursors.Hand;
            CreateTaskButton.FlatStyle = FlatStyle.Popup;
            CreateTaskButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CreateTaskButton.Location = new Point(105, 373);
            CreateTaskButton.Name = "CreateTaskButton";
            CreateTaskButton.Size = new Size(97, 77);
            CreateTaskButton.TabIndex = 15;
            CreateTaskButton.Text = "Create task";
            CreateTaskButton.UseVisualStyleBackColor = false;
            CreateTaskButton.Click += CreateTaskButton_Click;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameLabel.Location = new Point(12, 11);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(110, 25);
            UsernameLabel.TabIndex = 16;
            UsernameLabel.Text = "Welcome, ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(473, 28);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 18;
            label2.Text = "Sort by:";
            // 
            // SortByComboBox
            // 
            SortByComboBox.BackColor = SystemColors.Menu;
            SortByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SortByComboBox.FlatStyle = FlatStyle.Popup;
            SortByComboBox.FormattingEnabled = true;
            SortByComboBox.Items.AddRange(new object[] { "-- No Sort--", "Date" });
            SortByComboBox.Location = new Point(531, 25);
            SortByComboBox.Name = "SortByComboBox";
            SortByComboBox.Size = new Size(121, 23);
            SortByComboBox.TabIndex = 17;
            SortByComboBox.SelectedIndexChanged += HandleSortByChange;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // NextPageButton
            // 
            NextPageButton.BackColor = Color.Transparent;
            NextPageButton.Cursor = Cursors.Hand;
            NextPageButton.Enabled = false;
            NextPageButton.FlatAppearance.BorderSize = 0;
            NextPageButton.FlatStyle = FlatStyle.Popup;
            NextPageButton.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            NextPageButton.ForeColor = Color.Black;
            NextPageButton.ImageAlign = ContentAlignment.MiddleRight;
            NextPageButton.Location = new Point(332, 266);
            NextPageButton.Name = "NextPageButton";
            NextPageButton.Size = new Size(88, 33);
            NextPageButton.TabIndex = 23;
            NextPageButton.Text = "Next";
            NextPageButton.UseVisualStyleBackColor = false;
            NextPageButton.Click += NextPageButton_Click;
            // 
            // PreviousPageButton
            // 
            PreviousPageButton.BackColor = Color.Transparent;
            PreviousPageButton.BackgroundImage = (Image)resources.GetObject("PreviousPageButton.BackgroundImage");
            PreviousPageButton.Cursor = Cursors.Hand;
            PreviousPageButton.Enabled = false;
            PreviousPageButton.FlatAppearance.BorderSize = 0;
            PreviousPageButton.FlatStyle = FlatStyle.Popup;
            PreviousPageButton.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            PreviousPageButton.ForeColor = Color.Black;
            PreviousPageButton.Location = new Point(234, 266);
            PreviousPageButton.Name = "PreviousPageButton";
            PreviousPageButton.Size = new Size(92, 33);
            PreviousPageButton.TabIndex = 24;
            PreviousPageButton.Text = "Previous";
            PreviousPageButton.UseVisualStyleBackColor = false;
            PreviousPageButton.Click += PreviousPageButton_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Navy;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(9, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Size = new Size(643, 178);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellClick += EditRowFromDb;
            dataGridView1.CellDoubleClick += DeleteRowFromDb;
            // 
            // LogoutButton
            // 
            LogoutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LogoutButton.BackColor = Color.Maroon;
            LogoutButton.Cursor = Cursors.Hand;
            LogoutButton.FlatStyle = FlatStyle.Popup;
            LogoutButton.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutButton.ForeColor = SystemColors.ButtonHighlight;
            LogoutButton.Location = new Point(9, 446);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(74, 33);
            LogoutButton.TabIndex = 24;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(215, 262);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(205, 265);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(16, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(407, 262);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(431, 265);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(16, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(995, 389);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(75, 137);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 30;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(692, -7);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(77, 69);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 31;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Cursor = Cursors.Hand;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(6, 43);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(44, 46);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 32;
            pictureBox8.TabStop = false;
            pictureBox8.Click += ReportButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox8);
            groupBox2.Cursor = Cursors.Hand;
            groupBox2.Location = new Point(94, 393);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(58, 95);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(90, 406);
            label9.Name = "label9";
            label9.Size = new Size(64, 26);
            label9.TabIndex = 34;
            label9.Text = "Report";
            label9.Click += ReportButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1063, 491);
            Controls.Add(label9);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(LogoutButton);
            Controls.Add(dataGridView1);
            Controls.Add(PreviousPageButton);
            Controls.Add(NextPageButton);
            Controls.Add(label2);
            Controls.Add(SortByComboBox);
            Controls.Add(UsernameLabel);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(FilterComboBox);
            Controls.Add(SearchBarTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox SearchBarTextBox;
        //private DataGridView dataGridView1;
        private ComboBox FilterComboBox;
        private Label label1;
        private Label CreateOrEditLabel;
        private TextBox TitleTextBox;
        private TextBox DescriptionTextBox;
        private ComboBox PiriorityComboBox;
        private ComboBox StatusComboBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private Button CreateTaskButton;
        private Label UsernameLabel;
        private Label label8;
        private ComboBox CategoryComboBox;
        private Button CancelButton;
        private Button EditButton;
        private Label label2;
        private ComboBox SortByComboBox;
        //private Button PreviousPageButton;
        //private Button NextPageButton;
        private NotifyIcon notifyIcon1;
        private CustomControls.CustomDatePicker DueDatePicker;
        private CustomControls.CustomButton customButton1;
        private CustomControls.CustomButton NextPageButton;
        private CustomControls.CustomButton PreviousPageButton;
        private CustomControls.CustomGridView dataGridView1;
        private Button LogoutButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private GroupBox groupBox2;
        private Label label9;
    }
}