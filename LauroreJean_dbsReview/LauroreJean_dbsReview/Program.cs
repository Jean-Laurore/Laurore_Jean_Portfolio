using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LauroreJean_dbsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start\n");

            // MySQL Database Connection String
            string cs = @"server=127.0.0.1;userid=root;password=root;database=SampleAPIData;port=8889";

            // Declare a MySQL Connection
            MySqlConnection conn = null;

            //Prompt user for input
            Console.WriteLine("Enter a city: ");
            string city = Console.ReadLine();

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);
                conn.Open();

                // Form SQL Statement
                string stm = "select temp, pressure, humidity from weather where city = @city";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                //Binding Variables
                cmd.Parameters.AddWithValue("@city", city);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    //Console.WriteLine(rdr.GetDouble(0) + " " + rdr.GetDouble(0) + " " + rdr.GetInt32(0));
                    //string City = rdr["city"].ToString();

                    double Temp;
                    double.TryParse(rdr["temp"].ToString(), out Temp);

                    double Pressure;
                    double.TryParse(rdr["pressure"].ToString(), out Pressure);

                    double Humidity;
                    double.TryParse(rdr["humidity"].ToString(), out Humidity);

                    Console.WriteLine($"\nTemp: {Temp} Pressure: {Pressure} Humidity: {Humidity}");
                }
                else
                {
                    Console.WriteLine("\nNo Data Available for the selected city");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            Console.WriteLine("\nDone");
        }       
    }
}
