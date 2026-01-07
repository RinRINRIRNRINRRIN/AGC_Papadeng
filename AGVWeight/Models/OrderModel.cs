using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGVWeight.Models
{
    internal class OrderModel
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public string Typez { get; set; }
        public string LicensePlate { get; set; }
        public string Customer_name { get; set; }
        public string Product_name { get; set; }
        public string Transport_name { get; set; }
        public string SoNumber { get; set; }
        public string DnNo { get; set; }
        public string Shipment { get; set; }
        public string SealNo { get; set; }
        public string ContainerNo { get; set; }
        public int NetWeight { get; set; }
        /// <summary>
        /// สถานะชั่ง Success,Cancel,Process
        /// </summary>
        public string Status { get; set; }
        public string DateWeight { get; set; }
    }
}
