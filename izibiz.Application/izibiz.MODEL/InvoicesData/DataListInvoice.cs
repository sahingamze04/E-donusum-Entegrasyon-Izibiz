using izibiz.MODEL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izibiz.MODEL
{
    public class DataListInvoice: List<Invoices>
    {
        public static DataListInvoice GelenFaturalar;
        public static DataListInvoice GidenFaturalar;

    }
}
