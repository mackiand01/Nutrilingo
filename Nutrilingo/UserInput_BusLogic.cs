using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;


namespace Nutrilingo
{
    public class UserInput_BusLogic
    {
        public UserInput_BusLogic() { }

        //private int EntryID = 111;

        //string SysDate = DateTime.Now.ToString("MMMM dd, yyyy, HH:mm:ss");
        //string SysDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.mmm");

        public void DailyEntry_InsertData(string UserID, string carbs, string fats, string proteins, string alcohols, string date)
        {

            string connectionString = "Data Source=nutritech-appdb.caj8fvo1oxkf.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Nutrilingo_App;User ID=Nutri_Admin;Password=Duo.488dlal";

            SqlConnection connection = new SqlConnection(@connectionString);
            string query = "INSERT INTO MacroNutrient_DailyEntries(UserID, CarbContent, FatContent, ProteinContent, AlcoholContent, UserDate, EntryDate) VALUES (@USE, @CAR, @FAT, @PRO, @ALC, @E_DATE, convert(varchar, GetDate(), 21) );";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection;
            cmd.CommandText = query;

            cmd.Parameters.AddWithValue("@USE", UserID);
            cmd.Parameters.AddWithValue("@CAR", carbs);
            cmd.Parameters.AddWithValue("@FAT", fats);
            cmd.Parameters.AddWithValue("@PRO", proteins);
            cmd.Parameters.AddWithValue("@ALC", alcohols);
            cmd.Parameters.AddWithValue("@E_DATE", date);
            //cmd.Parameters.AddWithValue("@S_DATE", SysDate);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
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

    }
}