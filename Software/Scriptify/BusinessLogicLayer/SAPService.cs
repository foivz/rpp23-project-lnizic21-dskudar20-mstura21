using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Runtime.InteropServices;

namespace BusinessLogicLayer {
    public class SAPService {
        public List<SAPData> getScriptifyAproovedData() {
            using(SAPRepository sapRepository = new SAPRepository()) {
                var result = sapRepository.getScriptifyAproovedData();
                return result.ToList();
            }
        }
        public List<SAPScore> SAPDataFairAlgorithm() {
            using (SAPRepository repo = new SAPRepository()) {
                var sapData = repo.getScriptifyAproovedData().ToList();
                var libraryData = repo.getLibraryBookCounts().ToList();

                var exitData = (from sapItem in sapData
                                join libraryItem in libraryData on sapItem.IdLibrary equals libraryItem.Library_idLibrary
                                select new SAPScore {
                                    name = sapItem.Name,
                                    Loans = sapItem.Loans,
                                    BookCount = libraryItem.BookCount,
                                    Score = (sapItem.Loans / (decimal)libraryItem.BookCount)
                                }).OrderByDescending(x => x.Score).ToList();

                return exitData;
            }
        }

    }
}
