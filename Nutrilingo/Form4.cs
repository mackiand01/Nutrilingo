using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutrilingo
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void monthlyBtn_Click(object sender, EventArgs e)
        {
            chart.Text = "Monthly Statistics";

            //Create Chart and label Axis
            var objChart = chart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 30;
            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 2000;

            Random random = new Random();
            chart.Series.Clear();
            
            foreach (StatisticsMonthly s in statisticsMonthlyBindingSource.DataSource as List<StatisticsMonthly>)
            {
                //Add a new StatisticsMonthly object to the chart series
                chart.Series.Add(s.MacroNutrientType);
                //Assign that series a random color
                chart.Series[s.MacroNutrientType].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                //Add the series to the legend
                chart.Series[s.MacroNutrientType].Legend = "Legend1";
                //Set the Chart Area
                chart.Series[s.MacroNutrientType].ChartArea = "ChartArea1";
                //Set the type of chart to be displayed
                chart.Series[s.MacroNutrientType].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                //Loop through the StatisticsMontly object and grab all values from the day variables
                for (int i = 1; i <= 30; i++)
                {
                    chart.Series[s.MacroNutrientType].Points.AddXY(i, Convert.ToInt32(s[$"Day{i}"]));
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //Initialize the datagrid to be a new data source on load
            statisticsMonthlyBindingSource.DataSource = new List<StatisticsMonthly>();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 MenuForm = new Form2();
            this.Hide();
            MenuForm.Show();
        }
    }
}
