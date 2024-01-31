using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class UserWithCount
    {
        public int id_user { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime? create_time { get; set; }
        public int? Money { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int LoanCount { get; set; }

    }
}
