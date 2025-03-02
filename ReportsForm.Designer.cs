namespace Project_day3
{
    partial class ReportsForm
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
            cartesianChart = new LiveCharts.WinForms.CartesianChart();
            SuspendLayout();
            // 
            // cartesianChart
            // 
            cartesianChart.BackColor = SystemColors.ActiveCaption;
            cartesianChart.Location = new Point(12, 12);
            cartesianChart.Name = "cartesianChart";
            cartesianChart.Size = new Size(25, 21);
            cartesianChart.TabIndex = 0;
            cartesianChart.Text = "cartesianChart";
            cartesianChart.Visible = false;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(cartesianChart);
            Name = "ReportsForm";
            Text = "ReportsForm";
            ResumeLayout(false);
        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart;
    }
}