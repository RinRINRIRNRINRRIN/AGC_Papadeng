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
    internal class OrderDetailDb
    {

        public OrderDetailDb()
        {
            con = DbContact.SQLiteConnection;
            if (con.State != ConnectionState.Open)
                con.Open();

        }

        private readonly SQLiteConnection con;
        public string Error { get; set; }

        public bool addNew(OrderDetailModel model)
        {
            try
            {
                string sql = "INSERT INTO order_detail (order_id,weight,weightType,indicatorWeight,dateTimez) " +
                    "VALUES(@order_id,@weight,@weightType,@indicatorWeight,@dateTimez)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@order_id", model.OrderId));
                    cmd.Parameters.Add(new SQLiteParameter("@weight", model.Weight));
                    cmd.Parameters.Add(new SQLiteParameter("@weightType", model.WeightType));
                    cmd.Parameters.Add(new SQLiteParameter("@indicatorWeight", model.IndicatorWeight));
                    cmd.Parameters.Add(new SQLiteParameter("@dateTimez", model.DateTimez));
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


        /// <summary>
        /// สำหรับแสดงรายละเอียด
        /// </summary>
        /// <param name="id">เลขที่ id</param>
        /// <returns></returns>
        public List<OrderDetailModel> getOrderDetailById(int id)
        {
            List<OrderDetailModel> models = new List<OrderDetailModel>();
            try
            {
                string sql = "SELECT * FROM order_detail WHERE order_id = " + id;
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con))
                {
                    DataTable tb = new DataTable();
                    da.Fill(tb);
                    foreach (DataRow dr in tb.Rows)
                    {
                        OrderDetailModel model = new OrderDetailModel
                        {
                            Id = int.Parse(dr["Id"].ToString()),
                            DateTimez = DateTime.Parse(dr["dateTimez"].ToString()).ToString("dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.CreateSpecificCulture("th-TH")),
                            IndicatorWeight = dr["indicatorWeight"].ToString(),
                            OrderId = int.Parse(dr["order_id"].ToString()),
                            WeightType = dr["weightType"].ToString(),
                            Weight = int.Parse(dr["weight"].ToString())
                        };
                        models.Add(model);
                    }
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
            return models;
        }
    }
}
