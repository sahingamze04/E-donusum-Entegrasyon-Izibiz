using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izibiz.MODEL.Dto
{
  public  class Invoices
    {

        public string FaturaNumarası { get; set; }
        public string Ettn { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public string Senaryo { get; set; }
        public string FaturaTipi { get; set; }
        public string GönderenUnvan { get; set; }
        public string GönderenVknTckn { get; set; }
        public DateTime UlastıgiTarih { get; set; }
        public string ZarfID { get; set; }
        public string Durum { get; set; }
        public int GibDurum { get; set; }
        public string GibDurumAciklama { get; set; }
        public string UygulamaYanitDurumu { get; set; }
        public string GönderenGB { get; set; }
        public string AlıcıPK { get; set; }

    }
}
