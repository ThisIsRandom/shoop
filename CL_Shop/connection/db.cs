using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CL_Shop
{
    public class db
    {

        public static SqlConnection con;
      public static SqlConnection GetDbConnection()
      {
         if(db.con == null)
            {
                db.con = new SqlConnection("Data Source=HOME;Initial Catalog=shop;User ID=mbin;Password=password");
                db.con.Open();
                return db.con;
            }

            return db.con;
      }  

        public static void close()
        {
            db.con.Close();
        }
    }
}
