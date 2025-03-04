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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            TaskManagementContextDb taskManagementContextDb = new TaskManagementContextDb();
            string Name = NameTextBox.Text;
            string Email = EmailTextBox.Text;
            string Password = PasswordTextBox.Text;
            string ConfirmPassword = ConfirmPasswordTextBox.Text;

            var user = taskManagementContextDb.Users.Where(u => u.Email == Email || u.Name == Name).FirstOrDefault();
            if (user == null) 
            {
                if(ConfirmPassword != Password)
                {
                    MessageBox.Show("Password does not match");
                    return;
                }   
                var newUser = new User
                {
                    Name = Name,
                    Email = Email,
                    Password = Password
                };
                taskManagementContextDb.Users.Add(newUser);
                taskManagementContextDb.SaveChanges();
                this.Close();

            }
            else
            {
                MessageBox.Show("User already exists");
            }
        }
    }
}
