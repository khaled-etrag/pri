using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PRI_APP.BLL
{
    class employerBLL
    {
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Cfi { get; set; }
        public string Fonction { get; set; }
        public string Batiment { get; set; }
    }
}
