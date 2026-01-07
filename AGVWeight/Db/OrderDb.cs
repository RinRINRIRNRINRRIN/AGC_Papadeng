using AGVWeight.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGVWeight.Db
{
    internal class OrderDb
    {
        public OrderDb()
        {
            con = DbContact.SQLiteConnection;
            if (con.State != ConnectionState.Open)
                con.Open();
        }
        private readonly SQLiteConnection con;
        public string Error { get; set; }

        public string generateOrder()
        {
            string orderNumber = "";
            try
            {
                string yy = DateTime.Now.ToString("yy", System.Globalization.CultureInfo.CreateSpecificCulture("EN-en"));
                string MM = DateTime.Now.ToString("MM", System.Globalization.CultureInfo.CreateSpecificCulture("EN-en"));
                string dd = DateTime.Now.ToString("dd", System.Globalization.CultureInfo.CreateSpecificCulture("EN-en"));

                string sql = $"SELECT * FROM orderz WHERE orderNumber LIKE 'ORW{yy}{MM}{dd}%'";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con))
                {
                    DataTable tb = new DataTable();
                    int seq = 0;
                    da.Fill(tb);
                    seq = tb.Rows.Count + 1;
                    if (tb.Rows.Count == 0)
                        orderNumber = $"ORW{yy}{MM}{dd}-1";
                    else
                        orderNumber = $"ORW{yy}{MM}{dd}-{seq}";
                }

            }
            catch (Exception ex)
            {
                Error = ex.Message;
                Console.WriteLine(ex.Message);
                return null;
            }
            return orderNumber;
        }

        public bool addNew(OrderModel model)
        {
            try
            {
                string sql = "INSERT INTO orderz (orderNumber,type_name,licensePlate,customer_name,product_name,transport_name,soNo,dnNo,shipment,containerNo,sealNo,netWeight,status,dateWeight) " +
                    "VALUES (@orderNumber,@type_name,@licensePlate,@customer_name,@product_name,@transport_name,@soNo,@dnNo,@shipment,@containerNo,@sealNo,@netWeight,@status,@dateWeight)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@orderNumber", model.OrderNumber));
                    cmd.Parameters.Add(new SQLiteParameter("@type_name", model.Typez));
                    cmd.Parameters.Add(new SQLiteParameter("@licensePlate", model.LicensePlate));
                    cmd.Parameters.Add(new SQLiteParameter("@customer_name", model.Customer_name));
                    cmd.Parameters.Add(new SQLiteParameter("@product_name", model.Product_name));
                    cmd.Parameters.Add(new SQLiteParameter("@transport_name", model.Transport_name));
                    cmd.Parameters.Add(new SQLiteParameter("@soNo", model.SoNumber));
                    cmd.Parameters.Add(new SQLiteParameter("@dnNo", model.DnNo));
                    cmd.Parameters.Add(new SQLiteParameter("@shipment", model.Shipment));
                    cmd.Parameters.Add(new SQLiteParameter("@containerNo", model.ContainerNo));
                    cmd.Parameters.Add(new SQLiteParameter("@sealNo", model.SealNo));
                    cmd.Parameters.Add(new SQLiteParameter("@netWeight", model.NetWeight));
                    cmd.Parameters.Add(new SQLiteParameter("@status", model.Status));
                    cmd.Parameters.Add(new SQLiteParameter("@dateWeight", model.DateWeight));
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

        public bool deleteById(int id)
        {
            try
            {
                string sql = $"DELETE FROM orderz WHERE id = {id}";
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

        public bool updateStatusAndNetWeightById(int id, string status, int net)
        {
            try
            {
                string sql = "UPDATE orderz " +
                    "SET status = @status, " +
                    "netWeight = @netWeight " +
                    "WHERE id = @id";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@status", status));
                    cmd.Parameters.Add(new SQLiteParameter("@netWeight", net));
                    cmd.Parameters.Add(new SQLiteParameter("@id", id));
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

        List<OrderModel> defineModel(DataTable tb)
        {
            List<OrderModel> lists = new List<OrderModel>();
            try
            {
                foreach (DataRow rw in tb.Rows)
                {
                    OrderModel model = new OrderModel
                    {
                        Id = int.Parse(rw["id"].ToString()),
                        OrderNumber = rw["orderNumber"].ToString(),
                        Typez = rw["type_name"].ToString(),
                        LicensePlate = rw["licensePlate"].ToString(),
                        Customer_name = rw["customer_name"].ToString(),
                        Product_name = rw["product_name"].ToString(),
                        Transport_name = rw["transport_name"].ToString(),
                        SoNumber = rw["soNo"].ToString(),
                        DnNo = rw["dnNo"].ToString(),
                        Shipment = rw["shipment"].ToString(),
                        ContainerNo = rw["containerNo"].ToString(),
                        SealNo = rw["sealNo"].ToString(),
                        NetWeight = int.Parse(rw["netWeight"].ToString()),
                        Status = rw["status"].ToString(),
                        DateWeight = rw["dateWeight"].ToString()
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

        public OrderModel getOrderById(int id)
        {
            OrderModel model = new OrderModel();
            try
            {
                string sql = $"SELECT * FROM orderz WHERE id = {id}";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con))
                {
                    DataTable tb = new DataTable();
                    da.Fill(tb);
                    if (tb == null || tb.Rows.Count == 0)
                    {
                        return null;
                    }
                    foreach (DataRow rw in tb.Rows)
                        model = new OrderModel
                        {
                            Id = int.Parse(rw["id"].ToString()),
                            OrderNumber = rw["orderNumber"].ToString(),
                            Typez = rw["type_name"].ToString(),
                            LicensePlate = rw["licensePlate"].ToString(),
                            Customer_name = rw["customer_name"].ToString(),
                            Product_name = rw["product_name"].ToString(),
                            Transport_name = rw["transport_name"].ToString(),
                            SoNumber = rw["soNo"].ToString(),
                            DnNo = rw["dnNo"].ToString(),
                            Shipment = rw["shipment"].ToString(),
                            ContainerNo = rw["containerNo"].ToString(),
                            SealNo = rw["sealNo"].ToString(),
                            NetWeight = int.Parse(rw["netWeight"].ToString()),
                            Status = rw["status"].ToString(),
                            DateWeight = rw["dateWeight"].ToString()
                        };
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
            return model;
        }

        public OrderModel getOrderByOrderNumber(string orderNumber)
        {
            OrderModel model = new OrderModel();
            try
            {
                string sql = $"SELECT * FROM orderz WHERE orderNumber = '{orderNumber}'";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con))
                {
                    DataTable tb = new DataTable();
                    da.Fill(tb);
                    if (tb == null || tb.Rows.Count == 0)
                    {
                        return null;
                    }
                    foreach (DataRow rw in tb.Rows)
                        model = new OrderModel
                        {
                            Id = int.Parse(rw["id"].ToString()),
                            OrderNumber = rw["orderNumber"].ToString(),
                            Typez = rw["type_name"].ToString(),
                            LicensePlate = rw["licensePlate"].ToString(),
                            Customer_name = rw["customer_name"].ToString(),
                            Product_name = rw["product_name"].ToString(),
                            Transport_name = rw["transport_name"].ToString(),
                            SoNumber = rw["soNo"].ToString(),
                            DnNo = rw["dnNo"].ToString(),
                            Shipment = rw["shipment"].ToString(),
                            ContainerNo = rw["containerNo"].ToString(),
                            SealNo = rw["sealNo"].ToString(),
                            NetWeight = int.Parse(rw["netWeight"].ToString()),
                            Status = rw["status"].ToString(),
                            DateWeight = rw["dateWeight"].ToString()
                        };
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
            return model;
        }

        public List<OrderModel> getOrderList(string startDate, string endDate, string status, string license, string orderNumber)
        {
            List<OrderModel> lists = new List<OrderModel>();
            try
            {
                string sql = $"SELECT * FROM orderz WHERE dateWeight BETWEEN '{startDate} 00:00:00' and '{endDate} 23:59:59' ";
                if (!status.Contains('-'))
                    sql += $"and status = '{status}'";
                if (license != "")
                    sql += $"and licensePlate LIKE '%{license}%'";
                if (orderNumber != "")
                    sql += $"and orderNumber LIKE '%{orderNumber}%'";


                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con))
                {
                    DataTable tb = new DataTable();
                    da.Fill(tb);
                    if (tb == null)
                    {
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

        public List<OrderModel> getOrderByStatus(string status)
        {
            List<OrderModel> lists = new List<OrderModel>();
            try
            {
                string sql = $"SELECT * FROM orderz WHERE status = '{status}'";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con))
                {
                    DataTable tb = new DataTable();
                    da.Fill(tb);
                    if (tb.Rows.Count == 0)
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
