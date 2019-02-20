using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izibiz.UI
{
    public partial class FrmInvoice : Form
    {
        public FrmInvoice()
        {
            InitializeComponent();
        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            localizationItemTextWrite();
        }



        private void localizationItemTextWrite()
        {
            //dil secimini sorgula
            if (Settings.Default.language == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }

            else
            {
                Localization.Culture = new CultureInfo("");
            }

            //eleman text yazdır
            this.Text = Localization.form_fatura;
         
        }
    }
}
