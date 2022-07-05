using System;
using System.Collections;
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
            
        }
        private void weeklyBtn_Click(object sender, EventArgs e)
        {
            showWeeklyStats();
        }
        private void monthlyBtn_Click(object sender, EventArgs e)
        {
            showMonthlyStats();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 MenuForm = new Form2();
            this.Hide();
            MenuForm.Show();
        }
        private void showWeeklyStats()
        {
            chart.Text = "Weekly Statistics";

            // Create a list.
            ArrayList listDataSource = new ArrayList();

            DateTime minDate = DateTime.Today.AddDays(-6);
            DateTime maxDate = DateTime.Today;

            const int DAYS = 7;
            // Populate the list with records.
            listDataSource.Add(new Record(1, "CarbContent", new int[DAYS] { 90, 25, 35, 10, 72, 60, 25 }));
            listDataSource.Add(new Record(2, "FatContent", new int[DAYS] { 15, 50, 90, 45, 72, 21, 50 }));
            listDataSource.Add(new Record(3, "AlcoholContent", new int[DAYS] { 21, 29, 10, 49, 72, 70, 47 }));
            listDataSource.Add(new Record(4, "ProteinContent", new int[DAYS] { 19, 29, 75, 49, 72, 35, 80 }));

            var objChart = chart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            objChart.AxisX.Minimum = minDate.ToOADate();
            objChart.AxisX.Maximum = maxDate.ToOADate();

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 100;

            Random random = new Random();
            chart.Series.Clear();

            foreach (Record t in listDataSource)
            {
                chart.Series.Add(t.CarbType);
                chart.Series[t.CarbType].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                chart.Series[t.CarbType].Legend = "Legend1";
                chart.Series[t.CarbType].ChartArea = "ChartArea1";
                chart.Series[t.CarbType].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                int i = -6;
                foreach (Object obj in t.Amounts)
                {
                    chart.Series[t.CarbType].Points.AddXY(DateTime.Today.AddDays(i).ToOADate(), obj);
                    ++i;
                }
            }
        }
        private void showMonthlyStats()
        {
            chart.Text = "Monthly Statistics";

            // Create a list.
            ArrayList listDataSource = new ArrayList();

            DateTime minDate = DateTime.Today.AddDays(-29);
            DateTime maxDate = DateTime.Today;

            const int DAYS = 30;
            // Populate the list with records.
            listDataSource.Add(new Record(1, "CarbContent", new int[DAYS] { 90, 25, 35, 10, 72, 60, 25, 90, 25, 35, 10, 72, 60, 25, 90, 25, 35, 10, 72, 60, 25, 90, 25, 35, 10, 72, 60, 25, 70, 31 }));
            listDataSource.Add(new Record(2, "FatContent", new int[DAYS] { 15, 50, 90, 45, 72, 21, 50, 90, 25, 35, 10, 72, 60, 25, 90, 25, 35, 10, 72, 60, 25, 90, 25, 35, 10, 72, 60, 25, 90, 25 }));
            listDataSource.Add(new Record(3, "AlcoholContent", new int[DAYS] { 21, 29, 10, 49, 72, 70, 47, 90, 25, 35, 10, 72, 60, 25, 90, 25, 35, 10, 72, 60, 25, 90, 25, 35, 10, 72, 60, 25, 90, 25 }));
            listDataSource.Add(new Record(4, "ProteinContent", new int[DAYS] { 19, 29, 75, 49, 72, 35, 80, 90, 25, 35, 10, 72, 60, 25, 90, 25, 35, 10, 72, 60, 25, 90, 25, 35, 10, 72, 60, 25, 90, 25 }));

            var objChart = chart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            objChart.AxisX.Minimum = minDate.ToOADate();
            objChart.AxisX.Maximum = maxDate.ToOADate();

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 100;

            Random random = new Random();
            chart.Series.Clear();

            foreach (Record t in listDataSource)
            {
                chart.Series.Add(t.CarbType);
                chart.Series[t.CarbType].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                chart.Series[t.CarbType].Legend = "Legend1";
                chart.Series[t.CarbType].ChartArea = "ChartArea1";
                chart.Series[t.CarbType].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                int i = -29;
                foreach (Object obj in t.Amounts)
                {
                    chart.Series[t.CarbType].Points.AddXY(DateTime.Today.AddDays(i).ToOADate(), obj);
                    ++i;
                }
            }
        }
    }
}
    public class Record
    {
        int id;
        DateTime date;
        string carbType;
        ArrayList amounts = new ArrayList();
        public Record(int id, string carbType, int[] amounts)
        {
            this.id = id;
            PopulateAmounts(amounts);
            this.carbType = carbType;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string CarbType
        {
            get { return carbType; }
            set { carbType = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public ArrayList Amounts
        {
            get { return amounts; }
            set { amounts = value; }
        }
        public void PopulateAmounts(int[] amounts)
        {
            for (int i = 0; i < amounts.Length; ++i)
            {
                this.amounts.Add(amounts[i]);
            }
        }

    }
