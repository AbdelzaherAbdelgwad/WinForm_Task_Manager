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
    public partial class CustomGridView: DataGridView
    {
        public CustomGridView()
        {
            this.EnableHeadersVisualStyles = false;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            this.RowTemplate.Height = 30;
            InitializeComponent();
        }
    }
}
