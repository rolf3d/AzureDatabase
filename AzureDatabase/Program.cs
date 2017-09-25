using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            string query = "select * from Guest";

            string con = "Data Source=hotelserverrolf.database.windows.net;Initial Catalog=HotelDB;Integrated Security=False;User ID=Rolles;Password=Holles28462846;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int Guest_NO = reader.GetInt32(0);
                            string Name = reader.GetString(1);
                            string Address = reader.GetString(2);


                            Console.WriteLine(Guest_NO + " " + Name + " " + Address);
                            if (Name.Contains("Sten"))
                            {
                                Console.WriteLine("Hej " + Name);
                                Console.ReadLine();
                            }
                        }
                    }
                }
                Console.ReadLine();

            }


        }
    }
}
