using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCv.Models
{
    public class PortfolioModel
    {
        public class Portfolyo
        {
            public int ID { get; set; }
            public string Baslik { get; set; }
            public string Aciklama { get; set; }
            public string Resim { get; set; } // Fotoğrafın yolu
        }

    }
}