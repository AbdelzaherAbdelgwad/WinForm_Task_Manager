
using Project_day3.Modals;
using TaskStatus = Project_day3.Modals.TaskStatus;

namespace Project_day3
{
    public partial class Form1 : Form
    {
        public int UserId { get; set; }
        TaskItem taskItem = new TaskItem();
        TaskManagementContextDb db = new TaskManagementContextDb();
        private int currentPage = 1;
        private int pageSize = 5;
        private List<dynamic> AlltasksData = new List<dynamic>();
        private List<dynamic> FilterTasksData = new List<dynamic>();
        private List<dynamic> SortedTasksData = new List<dynamic>();
        private List<dynamic> CurrentShownData = new List<dynamic>();
        private int dataLength = 0;
        List<dynamic> overdueTasks = new List<dynamic>();

        private void FetchData(int currentPage)
        {
            AlltasksData = db.TaskItems
                .Where(x => x.UserId == UserId)
                .Select(t => new
                {
                    t.Id,
                    t.Title,
                    Category_Name = t.Category.Name,
                    t.Description,
                    t.DueDate,
                    t.Priority,
                    t.Status
                })
                .ToList<dynamic>();

            dataLength = AlltasksData.Count;
            CurrentShownData = new List<dynamic>(AlltasksData);
            FilterTasksData = new List<dynamic>(AlltasksData);
            SortedTasksData = AlltasksData.OrderBy(t => t.DueDate).ToList<dynamic>();
            var pageData = AlltasksData
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize).ToList();
            dataGridView1.DataSource = pageData;
            if (pageData.Count > 0)
            {
                dataGridView1.Columns["Id"].Visible = false;
            }
            makeOverdueAlert();

        }
        private void dataAssign()
        {
            taskItem.UserId = this.UserId;
            taskItem.Title = TitleTextBox.Text;
            taskItem.Description = DescriptionTextBox.Text;
            taskItem.DueDate = DueDatePicker.Value;
            taskItem.Priority = PiriorityComboBox.SelectedItem.ToString() ?? "Low";
            taskItem.Status = (Modals.TaskStatus)Enum.Parse(typeof(Modals.TaskStatus), StatusComboBox.SelectedItem?.ToString() ?? "Pending");
            taskItem.CategoryId = CategoryComboBox.SelectedIndex + 1;

        }
        private void dataInputsClear()
        {
            TitleTextBox.Text = "";
            DescriptionTextBox.Text = "";
            DueDatePicker.Value = DateTime.Today;
            PiriorityComboBox.SelectedItem = "Low";
            StatusComboBox.SelectedItem = "Pending";
        }

        public Form1(int UserId, string? Username)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.ControlBox = false;

            UsernameLabel.Text += Username;
            this.UserId = UserId;
            var categories = db.Categories.Select(x => x.Name).ToList();
            CategoryComboBox.DataSource = categories;
            //initial values for dropdowns
            PiriorityComboBox.SelectedIndex = 0;
            StatusComboBox.SelectedIndex = 0;
            SortByComboBox.SelectedIndex = 0;
            FilterComboBox.SelectedIndex = 0;

            FetchData(currentPage);
            if (currentPage * pageSize < CurrentShownData.Count)
            {
                NextPageButton.Enabled = true;
            }
            ;

        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            dataAssign();
            taskItem.Id = 0;
            db.TaskItems.Add(taskItem);
            db.SaveChanges();
            FetchData(currentPage);
            dataInputsClear();

        }


        private void DeleteRowFromDb(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var SelectedId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                DialogResult result = MessageBox.Show(
                                        "Are you sure you want to Delete this Task?",
                                        "Confirmation",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question
                                        );
                if (result == DialogResult.Yes)
                {
                    var objToDelete = db.TaskItems.Where(t => t.Id == SelectedId).FirstOrDefault();
                    db.TaskItems.Remove(objToDelete);
                    db.SaveChanges();
                    FetchData(currentPage);
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void HandleSearchChange(object sender, EventArgs e)
        {
            var data = AlltasksData.Where(t =>
                                        (t.Title.Contains(SearchBarTextBox.Text) || t.Description.Contains(SearchBarTextBox.Text)))
                                    .ToList();
            dataGridView1.DataSource = data;
            if (data.Count > 0)
            {
                dataGridView1.Columns["Id"].Visible = false;
            }
            if (SearchBarTextBox.Text == "")
            {
                currentPage = 1;
                dataGridView1.DataSource = CurrentShownData.Take(pageSize).ToList();

            }
        }

        private void HandleFilterDataChange(object sender, EventArgs e)
        {
            CurrentShownData = SortByComboBox.SelectedIndex == 1 ? SortedTasksData : AlltasksData;
            if (FilterComboBox.SelectedIndex == 0)
            {
                dataGridView1.DataSource = CurrentShownData.Take(pageSize).ToList();
                FilterTasksData = AlltasksData;
            }
            else
            {
                var data = CurrentShownData.Where(t =>
                t.Status == (Modals.TaskStatus)Enum.Parse(typeof(Modals.TaskStatus), FilterComboBox.SelectedItem.ToString())).ToList<dynamic>();
                CurrentShownData = data;
                FilterTasksData = AlltasksData.Where(t =>
                t.Status == (Modals.TaskStatus)Enum.Parse(typeof(Modals.TaskStatus), FilterComboBox.SelectedItem.ToString())).ToList<dynamic>();
                dataGridView1.DataSource = data.Take(pageSize).ToList();
            }
            currentPage = 1;
            NextPageButton.Enabled = currentPage * pageSize < CurrentShownData.Count ? true : false;
            if (dataGridView1.Columns.Contains("Id"))
            {
                dataGridView1.Columns["Id"].Visible = false;
            }

        }

        private void EditRowFromDb(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var SelectedRow = dataGridView1.Rows[e.RowIndex];
                taskItem = db.TaskItems.Find((int)SelectedRow.Cells[0].Value);
                CreateOrEditLabel.Text = "Edit Data";
                // buttons activation            
                EditButton.Enabled = true;
                CancelButton.Enabled = true;
                CreateTaskButton.Enabled = false;
                //update inputs
                TitleTextBox.Text = SelectedRow.Cells[1].Value.ToString();
                CategoryComboBox.SelectedItem = SelectedRow.Cells[2].Value.ToString();
                DescriptionTextBox.Text = SelectedRow.Cells[3].Value.ToString();
                DueDatePicker.Value = (DateTime)SelectedRow.Cells[4].Value;
                PiriorityComboBox.SelectedItem = SelectedRow.Cells[5].Value.ToString();
                StatusComboBox.SelectedItem = SelectedRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CreateOrEditLabel.Text = "Create New Task";
            EditButton.Enabled = false;
            CancelButton.Enabled = false;
            CreateTaskButton.Enabled = true;
            dataInputsClear();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            dataAssign();
            db.Update(taskItem);
            db.SaveChanges();

            CreateOrEditLabel.Text = "Create New Task";
            EditButton.Enabled = false;
            CancelButton.Enabled = false;
            CreateTaskButton.Enabled = true;
            dataInputsClear();
            FetchData(currentPage);

            // return to default
            SearchBarTextBox.Text = "";
            FilterComboBox.SelectedIndex = 0;
            SortByComboBox.SelectedIndex = 0;
        }

        private void HandleSortByChange(object sender, EventArgs e)
        {
            if (SortByComboBox.SelectedIndex == 1)
            {
                currentPage = 1;
                var data = CurrentShownData
                    .OrderBy(t => t.DueDate)
                    .ToList<dynamic>();
                if (FilterComboBox.SelectedIndex != 0)
                {
                    data = data.Where(t => t.Status == (Modals.TaskStatus)Enum.Parse(typeof(Modals.TaskStatus), FilterComboBox.SelectedItem.ToString()))
                        .ToList<dynamic>();
                }
                CurrentShownData = data;
                dataGridView1.DataSource = data.Take(pageSize).ToList();

            }
            else
            {
                CurrentShownData = FilterComboBox.SelectedIndex != 0 ? FilterTasksData : AlltasksData;
                dataGridView1.DataSource = CurrentShownData.Take(pageSize).ToList();
            }
            if (dataGridView1.Columns.Contains("Id"))
            {
                dataGridView1.Columns["Id"].Visible = false;
            }
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {

            if (currentPage * pageSize < CurrentShownData.Count)
            {
                currentPage++;
                dataGridView1.DataSource = CurrentShownData.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
                PreviousPageButton.Enabled = true;
            }
            if (currentPage * pageSize >= CurrentShownData.Count)
            {
                NextPageButton.Enabled = false;
            }


        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                dataGridView1.DataSource = CurrentShownData.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
                NextPageButton.Enabled = true;

            }
            if (currentPage == 1)
            {
                PreviousPageButton.Enabled = false;
            }


        }
        private void ShowNotification(string title, string message, ToolTipIcon tipIcon)
        {
            NotifyIcon notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Information,
                Visible = true
            };
            notifyIcon.ShowBalloonTip(3000, title, message, tipIcon);
        }

        private void makeOverdueAlert()
        {
            overdueTasks = AlltasksData.Where(t => t.DueDate < DateTime.Now && t.Status != TaskStatus.Completed).ToList<dynamic>();

            if (overdueTasks.Count > 0)
            {
                ShowNotification("Overdue Tasks", $"You have {overdueTasks.Count} overdue tasks!", ToolTipIcon.Warning);
            }
        }

        private void GenerateReport()
        {

            var report = new
            {
                TotalTasks = AlltasksData.Count,
                CompletedTasks = AlltasksData.Where(t => t.Status == TaskStatus.Completed).Count(),
                PendingTasks = AlltasksData.Where(t => t.Status == TaskStatus.Pending).Count(),
                InProgress = AlltasksData.Where(t => t.Status == TaskStatus.InProgress).Count(),
                OverdueTasks = overdueTasks.Count
            };
            MessageBox.Show(
                $"Total Tasks: {report.TotalTasks}\n" +
                $"Completed Tasks: {report.CompletedTasks}\n" +
                $"Pending Tasks: {report.PendingTasks}\n" +
                $"In Progress Tasks: {report.InProgress}\n" +
                $"Overdue Tasks: {report.OverdueTasks}",
                "Report",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            ReportsForm frm = new ReportsForm(AlltasksData, overdueTasks);
            frm.ShowDialog();

        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

  
    }
}