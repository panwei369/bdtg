using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Model
{
   public class PagingModel
    {
        public int code { get; set; }
        public string msg { get; set; }
        public int count { get; set; }
        public DataTable data { get; set; }
    }
}
