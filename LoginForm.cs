using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_day3.Modals;

namespace Project_day3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ErrorForm errorForm = new ErrorForm();
            TaskManagementContextDb taskManagementContextDb = new TaskManagementContextDb();

            string? UserName = LoginNameTextBox.Text.ToLower();
            string password = PasswordTextBox.Text;
            int UserID = taskManagementContextDb.Users.Where(u => u.Name.ToLower() == UserName && u.Password == password).Select(u => u.Id).FirstOrDefault();
            string? DbUserName = taskManagementContextDb.Users.Where(x => x.Id == UserID && x.Name.ToLower() == UserName).Select(x => x.Name).FirstOrDefault();
            Form1 form1;
            if (UserID != 0 && DbUserName != null)
            {
                form1 = new Form1(UserID, DbUserName);
                form1.ShowDialog();
            }
            else
            {
                errorForm.ShowDialog();
            }

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
