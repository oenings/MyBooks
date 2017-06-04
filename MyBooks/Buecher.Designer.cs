namespace MyBooks
{
    partial class Buecher
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_erfassen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_loeschen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_erfassen
            // 
            this.btn_erfassen.Location = new System.Drawing.Point(12, 12);
            this.btn_erfassen.Name = "btn_erfassen";
            this.btn_erfassen.Size = new System.Drawing.Size(130, 23);
            this.btn_erfassen.TabIndex = 0;
            this.btn_erfassen.Text = "Bücher erfassen";
            this.btn_erfassen.UseVisualStyleBackColor = true;
            this.btn_erfassen.Click += new System.EventHandler(this.btn_erfassen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 223);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_loeschen
            // 
            this.btn_loeschen.Location = new System.Drawing.Point(148, 12);
            this.btn_loeschen.Name = "btn_loeschen";
            this.btn_loeschen.Size = new System.Drawing.Size(121, 23);
            this.btn_loeschen.TabIndex = 2;
            this.btn_loeschen.Text = "Bücher löschen";
            this.btn_loeschen.UseVisualStyleBackColor = true;
            this.btn_loeschen.Click += new System.EventHandler(this.btn_loeschen_Click);
            // 
            // Buecher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 276);
            this.Controls.Add(this.btn_loeschen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_erfassen);
            this.Name = "Buecher";
            this.Text = "MyBooks";
            this.Activated += new System.EventHandler(this.Buecher_Load);
            this.Load += new System.EventHandler(this.Buecher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_erfassen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_loeschen;
    }
}

