using Microsoft.Data.SqlClient;
using System;
using static BackendHamster.Object.Aktivities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHamster.Operations
{
    public class EndOfDay
    {
        public static void TakeOutHamsters()
        {           
            var manage = new cageManagement();
            using (var dbContext = new DbContextHamster())
            {
                SqlConnection conn = new SqlConnection(
                @"Server=LAPTOP-6GH4TEP5\SQLEXPRESS;Database=advBjornEklund;Trusted_Connection=True;MultipleActiveResultSets=true");
                SqlDataReader rdr = null;
                string query = $"DELETE FROM motionsBatch";
                using(conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {

                    }

                }
                foreach (var item in dbContext.hamsters)
                {
                    manage.RemoveCage(item);
                }


            }
        }
    }
}
