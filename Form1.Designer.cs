namespace GestionCommercial
{
    partial class GestionConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnInscrire = new System.Windows.Forms.Button();
            this.textLogin1 = new System.Windows.Forms.TextBox();
            this.textPwd1 = new System.Windows.Forms.TextBox();
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.utilisateur = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(299, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion Commerciale";
            // 
            // btnInscrire
            // 
            this.btnInscrire.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnInscrire.ForeColor = System.Drawing.Color.Silver;
            this.btnInscrire.Location = new System.Drawing.Point(659, 31);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(116, 50);
            this.btnInscrire.TabIndex = 2;
            this.btnInscrire.Text = "S\'inscrire";
            this.btnInscrire.UseVisualStyleBackColor = false;
            this.btnInscrire.Click += new System.EventHandler(this.button1_Click);
            // 
            // textLogin1
            // 
            this.textLogin1.Location = new System.Drawing.Point(279, 162);
            this.textLogin1.Name = "textLogin1";
            this.textLogin1.Size = new System.Drawing.Size(333, 26);
            this.textLogin1.TabIndex = 3;
            // 
            // textPwd1
            // 
            this.textPwd1.Location = new System.Drawing.Point(279, 240);
            this.textPwd1.Name = "textPwd1";
            this.textPwd1.Size = new System.Drawing.Size(333, 26);
            this.textPwd1.TabIndex = 4;
            this.textPwd1.UseSystemPasswordChar = true;
            this.textPwd1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSeConnecter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSeConnecter.Location = new System.Drawing.Point(470, 323);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(142, 50);
            this.btnSeConnecter.TabIndex = 7;
            this.btnSeConnecter.Text = "Se Connecter";
            this.btnSeConnecter.UseVisualStyleBackColor = false;
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(258, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Login ou Mot de Passe Incorrect";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.Location = new System.Drawing.Point(275, 401);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(165, 20);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mot de Passe oublié ?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Silver;
            this.checkBox1.Location = new System.Drawing.Point(279, 337);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Remember";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GestionCommercial.Properties.Resources.motdepasse;
            this.pictureBox3.Location = new System.Drawing.Point(210, 225);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // utilisateur
            // 
            this.utilisateur.Image = global::GestionCommercial.Properties.Resources.utilisateur;
            this.utilisateur.Location = new System.Drawing.Point(210, 145);
            this.utilisateur.Name = "utilisateur";
            this.utilisateur.Size = new System.Drawing.Size(63, 59);
            this.utilisateur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.utilisateur.TabIndex = 5;
            this.utilisateur.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionCommercial.Properties.Resources.voiture;
            this.pictureBox1.Location = new System.Drawing.Point(43, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GestionConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(822, 508);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSeConnecter);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.utilisateur);
            this.Controls.Add(this.textPwd1);
            this.Controls.Add(this.textLogin1);
            this.Controls.Add(this.btnInscrire);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "GestionConnexion";
            this.Text = "Gestion Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInscrire;
        private System.Windows.Forms.TextBox textLogin1;
        private System.Windows.Forms.TextBox textPwd1;
        private System.Windows.Forms.PictureBox utilisateur;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

