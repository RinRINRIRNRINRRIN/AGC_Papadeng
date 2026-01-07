using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGVWeight.Models
{
    internal class OrderDetailModel
    {

        /// <summary>
        /// เลขที่ ID AI
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// เลขที่ PK id order
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// วันเวลา
        /// </summary>
        public string DateTimez { get; set; }
        /// <summary>
        /// ประเภทชั่ง FIRST ,SECOND
        /// </summary>
        public string WeightType { get; set; }
        /// <summary>
        /// เครื่องชั่ง
        /// </summary>
        public string IndicatorWeight { get; set; }
        /// <summary>
        /// น้ำหนัก
        /// </summary>
        public int Weight { get; set; }
    }
}
