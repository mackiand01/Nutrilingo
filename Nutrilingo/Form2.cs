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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void InsertData(string carbs, string fats, string proteins, string alcohols, string date)
        {
            string connectionString = "Data Source=nutritech-appdb.caj8fvo1oxkf.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Nutrilingo_App;User ID=Nutri_Admin";
            SqlConnection connection = new SqlConnection(@connectionString);
            string query = $"INSERT INTO MacroNutrient_DailyEntries (CarbContent, FatContent, ProteinContent, AlcoholContent, UserDate) VALUES({carbs},{fats},{proteins},{alcohols},{date})";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");
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

        private void button1_Click(object sender, EventArgs e)
        {
            string carbs = carb_Int.Text.ToString();
            string fats = fat_Int.Text.ToString();
            string proteins = protein_Int.Text.ToString();
            string alcohols = alcohol_Int.Text.ToString();
            string date = date_Int.Text.ToString();

            InsertData(carbs, fats, proteins, alcohols, date);

            carb_Int.Clear();
            fat_Int.Clear();
            protein_Int.Clear();
            alcohol_Int.Clear();
            date_Int.Clear();
        }

        private void weeklyStatsBtn_Click(object sender, EventArgs e)
        {
            Form3 WeekStatsForm = new Form3();
            this.Hide();
            WeekStatsForm.Show();
        }

    }
}
