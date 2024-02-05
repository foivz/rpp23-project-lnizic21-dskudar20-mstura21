using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class BookWithCount
    {
        public int idBook {  get; set; }
        public string book_name { get; set; }
        public string overview { get; set; }
        public string author { get; set; }
        public string genre { get; set;}

        public int LoanCount { get; set; }

    }
}
