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
    internal class TypeDb
    {

        public TypeDb()
        {
            con = DbContact.SQLiteConnection;
            if (con.State != ConnectionState.Open)
                con.Open();
        }
        private readonly SQLiteConnection con;
        public string Error { get; set; }


        public bool addNew(TypeModel model)
        {
            try
            {
                string sql = "INSERT INTO typez (type_name) VALUES(@type_name)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@type_name", model.Namez));
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
                string sql = $"DELETE FROM typez WHERE id = '{id}'";
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

        public bool updateById(TypeModel model)
        {
            try
            {
                string sql = "UPDATE typez " +
                    "SET type_name = @type_name " +
                    "WHERE id = @id";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@type_name", model.Namez));
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

        List<TypeModel> defineModel(DataTable tb)
        {
            List<TypeModel> lists = new List<TypeModel>();
            try
            {
                foreach (DataRow dr in tb.Rows)
                {
                    TypeModel model = new TypeModel
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        Namez = dr["type_name"].ToString()
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

        public List<TypeModel> getAllType()
        {
            List<TypeModel> lists = new List<TypeModel>();
            try
            {
                string sql = "SELECT * FROM typez";

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

        public List<TypeModel> getTypeByLike(string type_name)
        {
            List<TypeModel> lists = new List<TypeModel>();
            try
            {
                string sql = $"SELECT * FROM typez WHERE type_name LIKE '%{type_name}%'";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con))
                {
                    DataTable tb = new DataTable();
                    da.Fill(tb);
                    if (tb.Rows.Count == 0 || tb == null)
                    {
                        Error = "ไม่พบรายการ";
                        return null;
                    }
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
