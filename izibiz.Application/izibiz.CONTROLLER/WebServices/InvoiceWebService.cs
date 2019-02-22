using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using izibiz.MODEL.Dto;
using izibiz.SERVICES.serviceOib;
using izibiz.MODEL;

namespace izibiz.CONTROLLER.Web_Services
{
   public class InvoiceWebService
    {

        EFaturaOIBPortClient EFaturaOIBPortClient = new EFaturaOIBPortClient();



        public List<Invoices> getInvoiceList()
        {
            using (new OperationContextScope(EFaturaOIBPortClient.InnerChannel))
            {
                var req = new GetInvoiceRequest //sistemdeki gelen efatura listesi için request parametreleri
                {
                    REQUEST_HEADER = new REQUEST_HEADERType()
                    {
                        SESSION_ID = Session.Default.id,
                        APPLICATION_NAME = "izibiz.Aplication",
                        COMPRESSED = "N"
                    },
                    INVOICE_SEARCH_KEY = new GetInvoiceRequestINVOICE_SEARCH_KEY()
                    {
                        LIMIT = 10,
                        LIMITSpecified = true,
                        READ_INCLUDEDSpecified = true,
                        READ_INCLUDED = true              
                    },
                     HEADER_ONLY = "Y"
                };

                INVOICE[] invoiceArray = EFaturaOIBPortClient.GetInvoice(req);
                List<Invoices> invoiceList = new List<Invoices>();

                    foreach (var inv in invoiceArray)
                    {
                    //GelenFaturalar bos ya da daha once bu FaturaNumarası eklenmemisse ekle
                    if (DataListInvoice.GelenFaturalar == null || DataListInvoice.GelenFaturalar.Where(x => x.FaturaNumarası == inv.ID).FirstOrDefault() == null)
                        {
                        Invoices invoice = new Invoices();
                        invoice.FaturaNumarası = inv.ID;
                        invoice.Ettn = inv.UUID;
                        invoice.FaturaTarihi = inv.HEADER.ISSUE_DATE;
                        invoice.Senaryo = inv.HEADER.PROFILEID;
                        invoice.FaturaTipi = inv.HEADER.INVOICE_TYPE_CODE;
                        invoice.GönderenUnvan = inv.HEADER.SUPPLIER;
                        invoice.GönderenVknTckn = inv.HEADER.SENDER;
                        invoice.UlastıgiTarih = inv.HEADER.CDATE;
                        invoice.ZarfID = inv.HEADER.ENVELOPE_IDENTIFIER;
                        invoice.Durum = inv.HEADER.STATUS;
                        invoice.GibDurum = inv.HEADER.GIB_STATUS_CODE;
                        invoice.GibDurumAciklama = inv.HEADER.GIB_STATUS_DESCRIPTION;
                        invoice.UygulamaYanitDurumu = inv.UUID;
                        invoice.GönderenGB = inv.HEADER.FROM;
                        invoice.AlıcıPK = inv.HEADER.TO;

                        invoiceList.Add(invoice);
                    }                 
                }

                if (DataListInvoice.GelenFaturalar==null)
                {
                    DataListInvoice.GelenFaturalar=invoiceList;
                }
                else
                {
                    DataListInvoice.GelenFaturalar.AddRange(invoiceList);
                }       
                return DataListInvoice.GelenFaturalar;    
            }
        }



      





    }
}
