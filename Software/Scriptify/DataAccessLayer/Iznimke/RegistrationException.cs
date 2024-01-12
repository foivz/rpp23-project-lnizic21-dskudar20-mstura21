using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Iznimke
{
    public class RegistrationException:ApplicationException
    {
        public string Message { get; set; }
        public RegistrationException(string message)
        {
            Message = message;
        }
    }
}
