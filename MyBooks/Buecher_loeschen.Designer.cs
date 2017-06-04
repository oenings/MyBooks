namespace MyBooks
{
    partial class Buecher_loeschen
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
            this.cb_titel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_loeschen = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_titel
            // 
            this.cb_titel.FormattingEnabled = true;
            this.cb_titel.Location = new System.Drawing.Point(12, 46);
            this.cb_titel.Name = "cb_titel";
            this.cb_titel.Size = new System.Drawing.Size(260, 21);
            this.cb_titel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titel auswählen";
            // 
            // btn_loeschen
            // 
            this.btn_loeschen.Location = new System.Drawing.Point(12, 96);
            this.btn_loeschen.Name = "btn_loeschen";
            this.btn_loeschen.Size = new System.Drawing.Size(107, 23);
            this.btn_loeschen.TabIndex = 2;
            this.btn_loeschen.Text = "Löschen";
            this.btn_loeschen.UseVisualStyleBackColor = true;
            this.btn_loeschen.Click += new System.EventHandler(this.btn_loeschen_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(158, 96);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(114, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Abbrechen";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Buecher_loeschen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 158);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_loeschen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_titel);
            this.Name = "Buecher_loeschen";
            this.Text = "Buecher_loeschen";
            this.Load += new System.EventHandler(this.Buecher_loeschen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_titel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_loeschen;
        private System.Windows.Forms.Button btn_cancel;
    }
}