using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class BookWithCount
    {
        public Book Book { get; set; }
        public int LoanCount { get; set; }

    }
}
