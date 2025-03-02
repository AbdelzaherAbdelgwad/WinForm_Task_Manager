using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_day3.CustomControls
{
    public partial class CustomButton : Button
    {
        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.Gray;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 10, FontStyle.Bold);
            this.FlatAppearance.BorderSize = 0;
            InitializeComponent();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            // Change background color on hover
            this.BackColor = Color.DarkGray;
            this.ForeColor = Color.White;

        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            // Revert to original color when the mouse leaves
            this.BackColor = Color.Gray;
            this.ForeColor = Color.Black;

        }
    }
}
