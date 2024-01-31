using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer {
    public class SAPData {
        private int _idLibrary { get; set; }
        private string _name { get; set; }
        private int _loans { get; set; }

        public string Status { get; set; }

        public int IdLibrary {
            get { return _idLibrary; }
            set { _idLibrary = value; }
        }
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public int Loans {
            get { return _loans; }
            set {
                _loans = value; if (value > 30) {
                    Status = "Scriptify Aprooved";
                } else {
                    Status = "Scriptify not Aprooved";
                }
            }
        }
    }
}