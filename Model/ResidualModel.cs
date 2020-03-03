using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class ResidualModel
    {
        public int YId { get; set; }
        public int CId { get; set; }
        public int DId { get; set; }
        public float Piont { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal ZHeAccountBalance { get; set; }
        public int State { get; set; }
        public string DName { get; set; }
        public string CName { get; set; }
    }
}
