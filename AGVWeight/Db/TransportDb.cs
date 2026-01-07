using AGVWeight.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGVWeight.Db
{
    internal class TransportDb
    {
        public TransportDb()
        {
            con = DbContact.SQLiteConnection;
            if (con.State != ConnectionState.Open)
                con.Open();
        }
        private readonly SQLiteConnection con;
        public string Error { get; set; }
        public bool addNew(TransportModel model)
        {
            try
            {
                string sql = "INSERT INTO transport (transport_name) VALUES(@transport_name)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@transport_name", model.Namez));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
            return true;
        }

        public bool removeById(int id)
        {
            try
            {
                string sql = $"DELETE FROM transport WHERE id = '{id}'";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
            return true;
        }

        public bool updateById(TransportModel model)
        {
            try
            {
                string sql = "UPDATE transport " +
                    "SET transport_name = @transport_name " +
                    "WHERE id = @id";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@transport_name", model.Namez));
                    cmd.Parameters.Add(new SQLiteParameter("@id", model.Id));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
            return true;
        }

        List<TransportModel> defineModel(DataTable tb)
        {
            List<TransportModel> lists = new List<TransportModel>();
            try
            {
                foreach (DataRow dr in tb.Rows)
                {
                    TransportModel model = new TransportModel
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        Namez = dr["transport_name"].ToString()
                    };
                    lists.Add(model);
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
            return lists;
        }

        public List<TransportModel> getAllTransport()
        {
            List<TransportModel> lists = new List<TransportModel>();
            try
            {
                string sql = "SELECT * FROM transport";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con))
                {
                    DataTable tb = new DataTable();
                    da.Fill(tb);
                    if (tb.Rows.Count == 0 || tb == null)
                        return null;
                    lists = defineModel(tb);
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
            return lists;
        }

        public List<TransportModel> getTransportNameByLike(string type_name)
        {
            List<TransportModel> lists = new List<TransportModel>();
            try
            {
                string sql = $"SELECT * FROM transport WHERE transport_name LIKE '%{type_name}%'";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con))
                {
                    DataTable tb = new DataTable();
                    da.Fill(tb);
                    if (tb.Rows.Count == 0 || tb == null)
                        return null;
                    lists = defineModel(tb);
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
            return lists;
        }

    }
}
