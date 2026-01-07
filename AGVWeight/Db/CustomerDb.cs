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
    internal class CustomerDb
    {
        public CustomerDb()
        {
            con = DbContact.SQLiteConnection;
            if (con.State != ConnectionState.Open)
                con.Open();
        }
        private readonly SQLiteConnection con;
        public string Error { get; set; }

        public bool addNew(CustomerModel model)
        {
            try
            {
                string sql = "INSERT INTO customer (customer_name) VALUES(@customer_name)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@customer_name", model.Namez));
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
                string sql = $"DELETE FROM customer WHERE id = '{id}'";
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

        public bool updateById(CustomerModel model)
        {
            try
            {
                string sql = "UPDATE customer " +
                    "SET customer_name = @customer_name " +
                    "WHERE id = @id";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@customer_name", model.Namez));
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

        List<CustomerModel> defineModel(DataTable tb)
        {
            List<CustomerModel> lists = new List<CustomerModel>();
            try
            {
                foreach (DataRow dr in tb.Rows)
                {
                    CustomerModel model = new CustomerModel
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        Namez = dr["customer_name"].ToString()
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

        public List<CustomerModel> getAllCustomer()
        {
            List<CustomerModel> lists = new List<CustomerModel>();
            try
            {
                string sql = "SELECT * FROM customer";
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

        public List<CustomerModel> getCustomerNameByLike(string type_name)
        {
            List<CustomerModel> lists = new List<CustomerModel>();
            try
            {
                string sql = $"SELECT * FROM customer WHERE customer_name LIKE '%{type_name}%'";
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
