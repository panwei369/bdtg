using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReceiptsModel
    {
        public int RId { get; set; }
        public DateTime Datatime { get; set; }
        public int CId { get; set; }
        public int DId { get; set; }
        public float Piont { get; set; }
        public decimal Recharge { get; set; }
        public decimal ShiRecharge { get; set; }
        public decimal DaiRecharge { get; set; }
        public decimal CaiRecharge { get; set; }
        public decimal Balance { get; set; }
        public decimal ZheBalance { get; set; }
        public decimal XiaoFei { get; set; }
        public decimal ZheXiao { get; set; }
        public string DName { get; set; }
        public String CName { get; set; }
    }
}
