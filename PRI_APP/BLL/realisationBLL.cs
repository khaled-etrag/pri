using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRI_APP.BLL
{
    class realisationBLL
    {
        public string Matricule { get; set; }
        public string NinvMachine { get; set; }
        public string ReferancePieces { get; set; }
        public int QuantitéRéaliser { get; set; }
        public int Rebut { get; set; }
        public decimal TempsOpration { get; set; }
        public DateTime DateRealisation { get; set; }
        public string Cfi { get; set; }
        public int Noperation { get; set; }
        public decimal TempsRealisation { get; set; }
        public int Id { get; set; }
    }
}
