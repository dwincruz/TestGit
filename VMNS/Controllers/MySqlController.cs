using Microsoft.Data.SqlClient;
using System.Data;

namespace VMNS.Controllers
{
    public class MySqlController
    {
        

        public SqlCommand Cmd;
        public SqlConnection Con;

        public SqlDataReader Reader; //public SqlDataAdapter sqladap;

        public void Query(string query)
        {      
            Con = new SqlConnection(conString());

            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
            Con.Open();
            Cmd = new SqlCommand(query, Con);
            if (query.Contains("select") || query.Contains("exec"))
            {
                Reader = Cmd.ExecuteReader();
                
            }
            else
            {
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
            
        }

        public string conString()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);
            IConfiguration config = builder.Build();
            return config.GetValue<string>("ConnectionStrings:ApplicationDbContextConnection");
        }
    }
}
