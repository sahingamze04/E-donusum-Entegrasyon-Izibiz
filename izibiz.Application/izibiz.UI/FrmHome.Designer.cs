namespace izibiz.UI
{
    partial class FrmHome
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFatura = new System.Windows.Forms.Button();
            this.btnArsiv = new System.Windows.Forms.Button();
            this.btnIrsaliye = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnFatura
            // 
            this.btnFatura.Location = new System.Drawing.Point(271, 111);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(127, 35);
            this.btnFatura.TabIndex = 8;
            this.btnFatura.Text = "E-Fatura";
            this.btnFatura.UseVisualStyleBackColor = true;
            this.btnFatura.Click += new System.EventHandler(this.btnFatura_Click);
            // 
            // btnArsiv
            // 
            this.btnArsiv.Location = new System.Drawing.Point(271, 192);
            this.btnArsiv.Name = "btnArsiv";
            this.btnArsiv.Size = new System.Drawing.Size(127, 35);
            this.btnArsiv.TabIndex = 10;
            this.btnArsiv.Text = "E-Arşiv";
            this.btnArsiv.UseVisualStyleBackColor = true;
            // 
            // btnIrsaliye
            // 
            this.btnIrsaliye.Location = new System.Drawing.Point(271, 265);
            this.btnIrsaliye.Name = "btnIrsaliye";
            this.btnIrsaliye.Size = new System.Drawing.Size(127, 35);
            this.btnIrsaliye.TabIndex = 11;
            this.btnIrsaliye.Text = "E-İrsaliye";
            this.btnIrsaliye.UseVisualStyleBackColor = true;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 455);
            this.Controls.Add(this.btnIrsaliye);
            this.Controls.Add(this.btnArsiv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFatura);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFatura;
        private System.Windows.Forms.Button btnArsiv;
        private System.Windows.Forms.Button btnIrsaliye;
    }
}