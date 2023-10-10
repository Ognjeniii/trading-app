namespace SoftverZaTrgovinu
{
    partial class frmPocetniEkran
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
            this.btnAdministracijaStatistika = new System.Windows.Forms.Button();
            this.btnProdajaNaplata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdministracijaStatistika
            // 
            this.btnAdministracijaStatistika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministracijaStatistika.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministracijaStatistika.ForeColor = System.Drawing.Color.Black;
            this.btnAdministracijaStatistika.Location = new System.Drawing.Point(12, 12);
            this.btnAdministracijaStatistika.Name = "btnAdministracijaStatistika";
            this.btnAdministracijaStatistika.Size = new System.Drawing.Size(448, 67);
            this.btnAdministracijaStatistika.TabIndex = 0;
            this.btnAdministracijaStatistika.Text = "Administration ";
            this.btnAdministracijaStatistika.UseVisualStyleBackColor = true;
            this.btnAdministracijaStatistika.Click += new System.EventHandler(this.btnAdministracijaStatistika_Click);
            // 
            // btnProdajaNaplata
            // 
            this.btnProdajaNaplata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdajaNaplata.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdajaNaplata.Location = new System.Drawing.Point(12, 97);
            this.btnProdajaNaplata.Name = "btnProdajaNaplata";
            this.btnProdajaNaplata.Size = new System.Drawing.Size(448, 67);
            this.btnProdajaNaplata.TabIndex = 1;
            this.btnProdajaNaplata.Text = "Sales and billing";
            this.btnProdajaNaplata.UseVisualStyleBackColor = true;
            this.btnProdajaNaplata.Click += new System.EventHandler(this.btnProdajaNaplata_Click);
            // 
            // frmPocetniEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 175);
            this.Controls.Add(this.btnProdajaNaplata);
            this.Controls.Add(this.btnAdministracijaStatistika);
            this.Name = "frmPocetniEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trading application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdministracijaStatistika;
        private System.Windows.Forms.Button btnProdajaNaplata;
    }
}

