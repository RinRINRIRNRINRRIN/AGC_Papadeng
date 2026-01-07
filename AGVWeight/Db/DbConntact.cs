using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGVWeight.Db
{
    internal class DbContact
    {
        DbContact()
        {
            dbAddress = Application.StartupPath + "\\AGC.sql";
        }
        private const string dbName = "AGC.db";

        private static string dbAddress;
        public static string Error { get; set; }
        public static SQLiteConnection _con;

        public static SQLiteConnection SQLiteConnection = new SQLiteConnection($"Data Source={dbName};Version=3;");

        public static bool connect()
        {
            try
            {

                if (SQLiteConnection.State != ConnectionState.Open)
                {
                    SQLiteConnection.Open();

                }


                return true;
            }
            catch (Exception ex)
            {


                return false;
            }

        }
        public static bool tryConnectDatabase()
        {
            try
            {
                dbAddress = $"Data Source={dbName};Version=3;";
                if (!File.Exists(Application.StartupPath + "\\" + dbName))
                {
                    Error = "ไม่พบไฟล์";
                    return false;
                }

                using (SQLiteConnection con = new SQLiteConnection(dbAddress))
                {
                    con.Open();
                    string sql = "SELECT * FROM typez";
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con))
                    {
                        DataTable tb = new DataTable();
                        da.Fill(tb);

                    }
                    _con = con;
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
            return true;
        }




    }
}
