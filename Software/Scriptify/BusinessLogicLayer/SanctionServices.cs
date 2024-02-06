using DataAccessLayer.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class SanctionServices
    {

        public bool SaveSanction(Sanction sanction)
        {
            bool isSuccessful = false;
            using (var repo = new SanctionRepository())
            {
                int affectedRows = repo.SaveSanction(sanction);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }
    }
}
