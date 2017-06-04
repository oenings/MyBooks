namespace MyBooks
{
    partial class Buecher_erfassen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_speichern = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_titel = new System.Windows.Forms.TextBox();
            this.tb_autor = new System.Windows.Forms.TextBox();
            this.cb_format = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Format";
            // 
            // btn_speichern
            // 
            this.btn_speichern.Location = new System.Drawing.Point(15, 174);
            this.btn_speichern.Name = "btn_speichern";
            this.btn_speichern.Size = new System.Drawing.Size(75, 23);
            this.btn_speichern.TabIndex = 3;
            this.btn_speichern.Text = "Speichern";
            this.btn_speichern.UseVisualStyleBackColor = true;
            this.btn_speichern.Click += new System.EventHandler(this.btn_speichern_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(104, 174);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Abbrechen";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_titel
            // 
            this.tb_titel.Location = new System.Drawing.Point(104, 18);
            this.tb_titel.Name = "tb_titel";
            this.tb_titel.Size = new System.Drawing.Size(100, 20);
            this.tb_titel.TabIndex = 5;
            // 
            // tb_autor
            // 
            this.tb_autor.Location = new System.Drawing.Point(104, 52);
            this.tb_autor.Name = "tb_autor";
            this.tb_autor.Size = new System.Drawing.Size(100, 20);
            this.tb_autor.TabIndex = 6;
            // 
            // cb_format
            // 
            this.cb_format.FormattingEnabled = true;
            this.cb_format.Items.AddRange(new object[] {
            "pdf",
            "epub",
            "mobi"});
            this.cb_format.Location = new System.Drawing.Point(104, 93);
            this.cb_format.Name = "cb_format";
            this.cb_format.Size = new System.Drawing.Size(100, 21);
            this.cb_format.TabIndex = 7;
            // 
            // Buecher_erfassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 225);
            this.Controls.Add(this.cb_format);
            this.Controls.Add(this.tb_autor);
            this.Controls.Add(this.tb_titel);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_speichern);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Buecher_erfassen";
            this.Text = "Buecher_erfassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_speichern;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox tb_titel;
        private System.Windows.Forms.TextBox tb_autor;
        private System.Windows.Forms.ComboBox cb_format;
    }
}