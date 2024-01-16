using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Iznimke
{
    public class IssueSanctionException:ApplicationException
    {
        public string Message { get; set; }
        public IssueSanctionException(string message)
        {
            Message = message;
        }
    }
}
