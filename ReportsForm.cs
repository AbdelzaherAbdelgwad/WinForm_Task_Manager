
using LiveCharts.Wpf;
using LiveCharts;
using CartesianChart = LiveCharts.WinForms.CartesianChart;
using TaskStatus = Project_day3.Modals.TaskStatus;

namespace Project_day3
{
    public partial class ReportsForm: Form
    {
        List<dynamic> AlltasksData;
        List<dynamic> overdueTasks;
        public ReportsForm(List<dynamic> allTasks, List<dynamic> overDueTasks)
        {
            AlltasksData = allTasks;
            overdueTasks = overDueTasks;
            InitializeComponent();
            InitializeChart();
        }
        private void InitializeChart()
        {
            cartesianChart = new CartesianChart
            {
                Dock = DockStyle.Bottom,
                Height = 450,
                BackColor = Color.AliceBlue,
            };

            this.Controls.Add(cartesianChart);
            UpdateChart();
        }
        private void UpdateChart()
        {
            cartesianChart.Series = new SeriesCollection
            {
                new ColumnSeries { Title = "Total Tasks", Values = new ChartValues<int> { AlltasksData.Count } },
                new ColumnSeries { Title = "Completed", Values = new ChartValues<int> { AlltasksData.Count(t => t.Status == TaskStatus.Completed) } },
                new ColumnSeries { Title = "Pending", Values = new ChartValues<int> { AlltasksData.Count(t => t.Status == TaskStatus.Pending) } },
                new ColumnSeries { Title = "In Progress", Values = new ChartValues<int> { AlltasksData.Count(t => t.Status == TaskStatus.InProgress) } },
                new ColumnSeries { Title = "Overdue", Values = new ChartValues<int> { overdueTasks.Count } }
            };

            cartesianChart.AxisX.Clear();
            cartesianChart.AxisX.Add(new Axis { Labels = new[] { "Tasks" } });

            cartesianChart.AxisY.Clear();
            cartesianChart.AxisY.Add(new Axis { Title = "Count", LabelFormatter = value => value.ToString("N0") });
        }
    }

}
