namespace izibiz.UI
{
    partial class FrmInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuInvoice = new System.Windows.Forms.MenuStrip();
            this.itemComingInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.itemComingListInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSentInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDraftInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.itemNewInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.tableGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuInvoice
            // 
            this.menuInvoice.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuInvoice.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuInvoice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.menuInvoice.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuInvoice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemComingInvoice,
            this.itemSentInvoice,
            this.itemDraftInvoice,
            this.itemNewInvoice});
            this.menuInvoice.Location = new System.Drawing.Point(0, 0);
            this.menuInvoice.Name = "menuInvoice";
            this.menuInvoice.Size = new System.Drawing.Size(138, 538);
            this.menuInvoice.TabIndex = 0;
            this.menuInvoice.Text = "menuStrip1";
            // 
            // itemComingInvoice
            // 
            this.itemComingInvoice.BackColor = System.Drawing.Color.Teal;
            this.itemComingInvoice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemComingListInvoice});
            this.itemComingInvoice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.itemComingInvoice.Margin = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.itemComingInvoice.Name = "itemComingInvoice";
            this.itemComingInvoice.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.itemComingInvoice.Size = new System.Drawing.Size(131, 29);
            this.itemComingInvoice.Text = "Gelen Faturalar";
            // 
            // itemComingListInvoice
            // 
            this.itemComingListInvoice.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.itemComingListInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemComingListInvoice.Name = "itemComingListInvoice";
            this.itemComingListInvoice.Size = new System.Drawing.Size(186, 24);
            this.itemComingListInvoice.Text = "E-Fatura Listele";
            this.itemComingListInvoice.Click += new System.EventHandler(this.itemComingListInvoice_Click);
            // 
            // itemSentInvoice
            // 
            this.itemSentInvoice.BackColor = System.Drawing.Color.DarkSlateGray;
            this.itemSentInvoice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.itemSentInvoice.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.itemSentInvoice.Name = "itemSentInvoice";
            this.itemSentInvoice.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.itemSentInvoice.Size = new System.Drawing.Size(131, 29);
            this.itemSentInvoice.Text = " Giden Faturalar";
            // 
            // itemDraftInvoice
            // 
            this.itemDraftInvoice.BackColor = System.Drawing.Color.DarkSlateGray;
            this.itemDraftInvoice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.itemDraftInvoice.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.itemDraftInvoice.Name = "itemDraftInvoice";
            this.itemDraftInvoice.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.itemDraftInvoice.Size = new System.Drawing.Size(131, 29);
            this.itemDraftInvoice.Text = "Taslak Faturalar";
            // 
            // itemNewInvoice
            // 
            this.itemNewInvoice.BackColor = System.Drawing.Color.DarkSlateGray;
            this.itemNewInvoice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.itemNewInvoice.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.itemNewInvoice.Name = "itemNewInvoice";
            this.itemNewInvoice.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.itemNewInvoice.Size = new System.Drawing.Size(131, 29);
            this.itemNewInvoice.Text = "+Yeni Fatura";
            // 
            // tableGrid
            // 
            this.tableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26});
            this.tableGrid.Location = new System.Drawing.Point(152, 48);
            this.tableGrid.Name = "tableGrid";
            this.tableGrid.Size = new System.Drawing.Size(1056, 457);
            this.tableGrid.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Fatura Numarası";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Fatura ETTN";
            this.Column2.Name = "Column2";
            this.Column2.Width = 87;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "SENDER";
            this.dataGridViewTextBoxColumn14.HeaderText = "Fatura Tarihi";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 84;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "PROFILEID";
            this.dataGridViewTextBoxColumn15.HeaderText = "Senaryo";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 71;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "INVOICE_TYPE_CODE";
            this.dataGridViewTextBoxColumn16.HeaderText = "Fatura Tipi";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 76;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "SENDER";
            this.dataGridViewTextBoxColumn17.HeaderText = "Gönderen Ünvan";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 105;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn18.DataPropertyName = "SUPPLIER";
            this.dataGridViewTextBoxColumn18.HeaderText = "Gönderen VKN/TCKN";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 126;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn19.DataPropertyName = "CDATE";
            this.dataGridViewTextBoxColumn19.HeaderText = "Ulaştığı Tarih";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 86;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ENVELOPE_IDENTIFIER";
            this.dataGridViewTextBoxColumn20.HeaderText = "Zarf ID";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 51;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn21.DataPropertyName = "STATUS";
            this.dataGridViewTextBoxColumn21.HeaderText = "Durum";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 63;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn22.DataPropertyName = "GIB_STATUS_CODE";
            this.dataGridViewTextBoxColumn22.HeaderText = "Gib Durum";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 76;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn23.DataPropertyName = "GIB_STATUS_DESCRIPTION";
            this.dataGridViewTextBoxColumn23.HeaderText = "GİB Durum Açıklama";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 119;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn24.DataPropertyName = "STATUS_DESCRIPTION";
            this.dataGridViewTextBoxColumn24.HeaderText = "Uygulama Yanıt Durumu";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn25.DataPropertyName = "FROM";
            this.dataGridViewTextBoxColumn25.HeaderText = "Gönderen GB";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 89;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn26.DataPropertyName = "TO";
            this.dataGridViewTextBoxColumn26.HeaderText = "Alıcı PK";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 51;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(535, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 16);
            this.lblTitle.TabIndex = 13;
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1247, 538);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tableGrid);
            this.Controls.Add(this.menuInvoice);
            this.MainMenuStrip = this.menuInvoice;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInvoice";
            this.Text = "FrmInvoice";
            this.Load += new System.EventHandler(this.FrmInvoice_Load);
            this.menuInvoice.ResumeLayout(false);
            this.menuInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuInvoice;
        private System.Windows.Forms.ToolStripMenuItem itemComingInvoice;
        private System.Windows.Forms.ToolStripMenuItem itemSentInvoice;
        private System.Windows.Forms.ToolStripMenuItem itemDraftInvoice;
        private System.Windows.Forms.ToolStripMenuItem itemNewInvoice;
        private System.Windows.Forms.ToolStripMenuItem itemComingListInvoice;
        private System.Windows.Forms.DataGridView tableGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.Label lblTitle;
    }
}