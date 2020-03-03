using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class StatisticsModel
    {
        public int SId { get; set; }
        public DateTime DataTime { get; set; }
        public int CId { get; set; }
        public int DId { get; set; }
        public float Piont { get; set; }
        public decimal RechargeSt { get; set; }
        public decimal ZheRechargeSt { get; set; }
        public int State { get; set; }
        public string DName { get; set; }
        public string CName { get; set; }
    }
}
