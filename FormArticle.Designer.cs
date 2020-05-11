namespace GestionCommercial
{
    partial class FormArticle
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvArticle = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.cboCategorie = new System.Windows.Forms.ComboBox();
            this.textLibelle = new System.Windows.Forms.TextBox();
            this.textStock = new System.Windows.Forms.TextBox();
            this.textPrix = new System.Windows.Forms.TextBox();
            this.textReference = new System.Windows.Forms.TextBox();
            this.labelCategorie = new System.Windows.Forms.Label();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelReference = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvArticle)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(739, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Gestion Commerciale\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtgvArticle
            // 
            this.dtgvArticle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvArticle.Location = new System.Drawing.Point(446, 61);
            this.dtgvArticle.Name = "dtgvArticle";
            this.dtgvArticle.RowTemplate.Height = 28;
            this.dtgvArticle.Size = new System.Drawing.Size(868, 605);
            this.dtgvArticle.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnEnregistrer);
            this.panel1.Controls.Add(this.cboCategorie);
            this.panel1.Controls.Add(this.textLibelle);
            this.panel1.Controls.Add(this.textStock);
            this.panel1.Controls.Add(this.textPrix);
            this.panel1.Controls.Add(this.textReference);
            this.panel1.Controls.Add(this.labelCategorie);
            this.panel1.Controls.Add(this.labelLibelle);
            this.panel1.Controls.Add(this.labelStock);
            this.panel1.Controls.Add(this.labelPrix);
            this.panel1.Controls.Add(this.labelReference);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(38, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 504);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(43, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 50);
            this.button1.TabIndex = 24;
            this.button1.Text = "Effacer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEnregistrer.Location = new System.Drawing.Point(235, 415);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(142, 50);
            this.btnEnregistrer.TabIndex = 23;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // cboCategorie
            // 
            this.cboCategorie.FormattingEnabled = true;
            this.cboCategorie.Items.AddRange(new object[] {
            "Pickup",
            "Berline",
            "4x4",
            "Coupé",
            "Familiale",
            "Sportive"});
            this.cboCategorie.Location = new System.Drawing.Point(147, 350);
            this.cboCategorie.Name = "cboCategorie";
            this.cboCategorie.Size = new System.Drawing.Size(220, 28);
            this.cboCategorie.TabIndex = 22;
            // 
            // textLibelle
            // 
            this.textLibelle.Location = new System.Drawing.Point(147, 155);
            this.textLibelle.Name = "textLibelle";
            this.textLibelle.Size = new System.Drawing.Size(220, 26);
            this.textLibelle.TabIndex = 21;
            // 
            // textStock
            // 
            this.textStock.Location = new System.Drawing.Point(147, 225);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(220, 26);
            this.textStock.TabIndex = 20;
            // 
            // textPrix
            // 
            this.textPrix.Location = new System.Drawing.Point(147, 287);
            this.textPrix.Name = "textPrix";
            this.textPrix.Size = new System.Drawing.Size(220, 26);
            this.textPrix.TabIndex = 19;
            // 
            // textReference
            // 
            this.textReference.Location = new System.Drawing.Point(147, 87);
            this.textReference.Name = "textReference";
            this.textReference.Size = new System.Drawing.Size(220, 26);
            this.textReference.TabIndex = 18;
            // 
            // labelCategorie
            // 
            this.labelCategorie.AutoSize = true;
            this.labelCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategorie.Location = new System.Drawing.Point(39, 350);
            this.labelCategorie.Name = "labelCategorie";
            this.labelCategorie.Size = new System.Drawing.Size(97, 22);
            this.labelCategorie.TabIndex = 17;
            this.labelCategorie.Text = "Catégorie";
            // 
            // labelLibelle
            // 
            this.labelLibelle.AutoSize = true;
            this.labelLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibelle.Location = new System.Drawing.Point(39, 155);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(69, 22);
            this.labelLibelle.TabIndex = 16;
            this.labelLibelle.Text = "Libelle";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(39, 225);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(60, 22);
            this.labelStock.TabIndex = 15;
            this.labelStock.Text = "Stock";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrix.Location = new System.Drawing.Point(39, 291);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(45, 22);
            this.labelPrix.TabIndex = 14;
            this.labelPrix.Text = "Prix";
            // 
            // labelReference
            // 
            this.labelReference.AutoSize = true;
            this.labelReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReference.Location = new System.Drawing.Point(34, 87);
            this.labelReference.Name = "labelReference";
            this.labelReference.Size = new System.Drawing.Size(102, 22);
            this.labelReference.TabIndex = 13;
            this.labelReference.Text = "Reference";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(66, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enregistrement Article";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(0, 664);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 699);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvArticle);
            this.Controls.Add(this.label2);
            this.Name = "FormArticle";
            this.Text = "Article";
            this.Load += new System.EventHandler(this.FormArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvArticle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvArticle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.ComboBox cboCategorie;
        private System.Windows.Forms.TextBox textLibelle;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.TextBox textPrix;
        private System.Windows.Forms.TextBox textReference;
        private System.Windows.Forms.Label labelCategorie;
        private System.Windows.Forms.Label labelLibelle;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelReference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}