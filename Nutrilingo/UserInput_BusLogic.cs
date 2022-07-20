using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;


namespace Nutrilingo
{
    public class UserInput_BusLogic
    {
        public UserInput_BusLogic() { }

        
        private string connectionString = "Data Source=nutritech-appdb.caj8fvo1oxkf.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Nutrilingo_App;User ID=Nutri_Admin;Password=Duo.488dlal";
        //private int EntryID = 111;

        //string SysDate = DateTime.Now.ToString("MMMM dd, yyyy, HH:mm:ss");
        //string SysDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.mmm");

        public void DailyEntry_InsertData(string UserID, string carbs, string fats, string proteins, string alcohols, string date)
        {


            SqlConnection connection = new SqlConnection(@connectionString);
            string query = "INSERT INTO MacroNutrient_DailyEntries(UserID, CarbContent, FatContent, ProteinContent, AlcoholContent, UserDate, convert(varchar,convert(date,EntryDate,101),120) VALUES (@USE, @CAR, @FAT, @PRO, @ALC, @E_DATE, convert(varchar, GetDate(), 21) );";

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

        // BEFORE TESTING
        // !! CHECK IF USERID AND Nutrient_Type STRINGS ARE BEING ADDED TO THE STRING PROPERLY

        public Dictionary<string, Dictionary<string, decimal>> UserData_Timeframe_DataPull(string UserID, string Time_Period, string[] Nutrient_Type )
        {
            
            string Date_furthestOut;
            string Date_mostRecent;

            // !! NUTRIENT TYPE NEEDS CHECK THAT IT HAS AT LEAST ONE VALID ELEMENT !!

            SqlConnection connection = new SqlConnection(@connectionString);

            

            string query = "SELECT FROM MacroNutrient_DailyEntries(EntryDate, ";
            
            foreach(string item in Nutrient_Type)
            {
                query += @"{item}, ";
            }


            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection;


            switch (Time_Period) 
            {
                case "week":
                    
                    Date_mostRecent = DateTime.Today.ToString("yyyy-MM-dd");
                    Date_furthestOut = DateTime.Today.AddDays(-7).ToString("yyyy-MM-dd");
                    
                    query += @") WHERE UserID='{UserID}' EntryDate BETWEEN @TIMEFRAME_oldest AND @TIMEFRAME_newest";
                    cmd.Parameters.AddWithValue("@TIMEFRAME_oldest", Date_furthestOut);
                    cmd.Parameters.AddWithValue("@TIMEFRAME_newest", Date_mostRecent);
                    break;
                case "month":

                    Date_mostRecent = DateTime.Today.ToString("yyyy-MM-dd");
                    Date_furthestOut = DateTime.Today.AddMonths(-1).ToString("yyyy-MM-dd");

                    query += @") WHERE UserID='{UserID}' AND EntryDate BETwEEN @TIMEFRAME_oldest AND @TIMEFRAME_newest";
                    cmd.Parameters.AddWithValue("@TIMEFRAME_oldest", Date_furthestOut);
                    cmd.Parameters.AddWithValue("@TIMEFRAME_newest", Date_mostRecent);
                    break;
                case "user_start":
                    query += @") WHERE UserID='{UserID}';";
                    break;
            }

            cmd.CommandText = query;
            
            try
            {  
                var DblKeyData = new Dictionary<string, Dictionary<string, decimal>>();

                //Appears to be a unused list I added, not sure why
                //List<string> ConList = new List<string>();

                connection.Open();
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReadIntDict((IDataRecord)reader, DblKeyData);
                    }
                }
               
                MessageBox.Show("Data retrieved successfully.");

                return DblKeyData;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error Generated. Details: " + ex.ToString());
                return null;
            }
            finally
            {
                connection.Close();
            }

        }

        public void ReadIntDict(IDataRecord dataRecord, Dictionary<string, Dictionary<string, decimal>> NestDict)
        {
                

            if (NestDict.ContainsKey(dataRecord[0].ToString()))
            {

                NestDict[dataRecord[0].ToString()].Add(dataRecord[1].ToString(), dataRecord.GetDecimal(2));
            }
            else
            {
                NestDict.Add(dataRecord[0].ToString(), new Dictionary<string, decimal>());
                NestDict[dataRecord[0].ToString()].Add(dataRecord[1].ToString(), dataRecord.GetDecimal(2));
            }
        }

    }
}