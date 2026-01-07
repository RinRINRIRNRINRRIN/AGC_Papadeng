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
    internal class ProductDb
    {
        public ProductDb()
        {
            con = DbContact.SQLiteConnection;
            if (con.State != ConnectionState.Open)
                con.Open();
        }
        private readonly SQLiteConnection con;
        public string Error { get; set; }


        public bool addNew(ProductModel model)
        {
            try
            {
                string sql = "INSERT INTO product (product_name) VALUES(@product_name)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@product_name", model.Namez));
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
                string sql = $"DELETE FROM product WHERE id = '{id}'";
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

        public bool updateById(ProductModel model)
        {
            try
            {
                string sql = "UPDATE product " +
                    "SET product_name = @product_name " +
                    "WHERE id = @id";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@product_name", model.Namez));
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

        List<ProductModel> defineModel(DataTable tb)
        {
            List<ProductModel> lists = new List<ProductModel>();
            try
            {
                foreach (DataRow dr in tb.Rows)
                {
                    ProductModel model = new ProductModel
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        Namez = dr["product_name"].ToString()
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

        public List<ProductModel> getAllProduct()
        {
            List<ProductModel> lists = new List<ProductModel>();
            try
            {
                string sql = "SELECT * FROM product";
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

        public List<ProductModel> getProductNameByLike(string type_name)
        {
            List<ProductModel> lists = new List<ProductModel>();
            try
            {
                string sql = $"SELECT * FROM product WHERE product_name LIKE '%{type_name}%'";
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
