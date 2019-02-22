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
                List<Invoices> setListInvoice = new List<Invoices>();
                Invoices setInvoice = new Invoices();

                     foreach(var invoice in invoiceArray)
                        {
                            setInvoice.FaturaNumarası = invoice.ID;
                            setInvoice.Ettn = invoice.UUID;
                            setInvoice.FaturaTarihi = invoice.HEADER.ISSUE_DATE;
                            setInvoice.Senaryo = invoice.HEADER.PROFILEID;
                            setInvoice.FaturaTipi = invoice.HEADER.INVOICE_TYPE_CODE;
                            setInvoice.GönderenUnvan = invoice.HEADER.SUPPLIER;
                            setInvoice.GönderenVknTckn = invoice.HEADER.SENDER;
                            setInvoice.UlastıgiTarih = invoice.HEADER.CDATE;
                            setInvoice.ZarfID = invoice.HEADER.ENVELOPE_IDENTIFIER;
                            setInvoice.Durum = invoice.HEADER.STATUS;
                            setInvoice.GibDurum = invoice.HEADER.GIB_STATUS_CODE;
                            setInvoice.GibDurumAciklama = invoice.HEADER.GIB_STATUS_DESCRIPTION;
                            setInvoice.UygulamaYanitDurumu = invoice.UUID;
                            setInvoice.GönderenGB = invoice.HEADER.FROM;
                            setInvoice.AlıcıPK = invoice.HEADER.TO;

                            setListInvoice.Add(setInvoice);
                        };

        //        DataListInvoice.GelenFaturalar =setListInvoice;
                return setListInvoice;    
            }

        }



      





    }
}
