using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer {
    public class SAPService {
        public List<SAPData> getScriptifyAproovedData() {
            using(SAPRepository sapRepository = new SAPRepository()) {
                var result = sapRepository.getScriptifyAproovedData();
                return result.ToList();
            }
        }
    }
}
