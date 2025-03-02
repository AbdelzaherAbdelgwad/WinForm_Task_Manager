using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_day3.CustomControls
{
    public partial class CustomDatePicker: DateTimePicker
    {
        public CustomDatePicker()
        {
            InitializeComponent();
        }
        protected override void OnValidating(CancelEventArgs e)
        {
            if (Value < DateTime.Today)
            {
                MessageBox.Show("Due date cannot be in the past.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; 
            }
            base.OnValidating(e);
        }
    }
}
