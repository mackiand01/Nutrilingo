using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Nutrilingo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Initialize the datagrid to be a new data source on load
            statisticsWeeklyBindingSource.DataSource = new List<StatisticsWeekly>();
        }

        /* 
         * This method will be for retreiving the data once it is working.
         * 
        private void RetreiveData(string carbs, string fats, string proteins, string alcohols, string date)
        {
            string connectionString = "Data Source=nutritech-appdb.caj8fvo1oxkf.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Nutrilingo_App;User ID=Nutri_Admin";
            SqlConnection connection = new SqlConnection(@connectionString);
            string query = $"SELECT * FROM MacroNutrient_DailyEntries (CarbContent, FatContent, ProteinContent, AlcoholContent, UserDate) VALUES({carbs},{fats},{proteins},{alcohols},{date})";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Data Retrieved Successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error Generated. Details: " + ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        */

        private void weeklyBtn_Click(object sender, EventArgs e)
        {
            chart.Text = "Weekly Statistics";
            var objChart = chart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 7;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 2000;

            Random random = new Random();
            chart.Series.Clear();

            
            foreach (StatisticsWeekly s in statisticsWeeklyBindingSource.DataSource as List<StatisticsWeekly>)
            {
                //Add a new StatisticsWeekly object to the chart series
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
                for (int i = 1; i <= 7; i++)
                {
                    chart.Series[s.MacroNutrientType].Points.AddXY(i, Convert.ToInt32(s[$"Day{i}"]));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 MenuForm = new Form2();
            this.Hide();
            MenuForm.Show();
        }
    }
}
