using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer {
    public class SAPScore {
        public string name { get; set; }
        public int BookCount { get; set; }
        public int Loans { get; set; }
        public decimal Score { get; set; }
    }
}
