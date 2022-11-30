namespace formulqire_des_livres
{
    partial class Form1
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
            this.ListeLivre = new System.Windows.Forms.ComboBox();
            this.titre = new System.Windows.Forms.TextBox();
            this.prix = new System.Windows.Forms.TextBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.labelliste = new System.Windows.Forms.Label();
            this.labeltitre = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListeLivre
            // 
            this.ListeLivre.FormattingEnabled = true;
            this.ListeLivre.Location = new System.Drawing.Point(180, 71);
            this.ListeLivre.Name = "ListeLivre";
            this.ListeLivre.Size = new System.Drawing.Size(336, 21);
            this.ListeLivre.TabIndex = 0;
            this.ListeLivre.SelectedIndexChanged += new System.EventHandler(this.ListeLivre_SelectedIndexChanged);
            // 
            // titre
            // 
            this.titre.Location = new System.Drawing.Point(181, 110);
            this.titre.Multiline = true;
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(335, 26);
            this.titre.TabIndex = 1;
            // 
            // prix
            // 
            this.prix.Location = new System.Drawing.Point(181, 151);
            this.prix.Multiline = true;
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(335, 27);
            this.prix.TabIndex = 2;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.BackColor = System.Drawing.Color.Tan;
            this.btnConfirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmer.Location = new System.Drawing.Point(384, 198);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(62, 26);
            this.btnConfirmer.TabIndex = 6;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = false;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.Tan;
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btninsert.Location = new System.Drawing.Point(180, 198);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(62, 26);
            this.btninsert.TabIndex = 7;
            this.btninsert.Text = "Ajouter";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Tan;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(248, 198);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(62, 26);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Tan;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(316, 198);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(62, 26);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Supprimer";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // labelliste
            // 
            this.labelliste.AutoSize = true;
            this.labelliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelliste.ForeColor = System.Drawing.Color.Tan;
            this.labelliste.Location = new System.Drawing.Point(19, 71);
            this.labelliste.Name = "labelliste";
            this.labelliste.Size = new System.Drawing.Size(122, 20);
            this.labelliste.TabIndex = 10;
            this.labelliste.Text = "liste des livres";
            // 
            // labeltitre
            // 
            this.labeltitre.AutoSize = true;
            this.labeltitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitre.ForeColor = System.Drawing.Color.Tan;
            this.labeltitre.Location = new System.Drawing.Point(19, 110);
            this.labeltitre.Name = "labeltitre";
            this.labeltitre.Size = new System.Drawing.Size(107, 20);
            this.labeltitre.TabIndex = 11;
            this.labeltitre.Text = "Titre de livre";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrix.ForeColor = System.Drawing.Color.Tan;
            this.labelPrix.Location = new System.Drawing.Point(19, 151);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(100, 20);
            this.labelPrix.TabIndex = 12;
            this.labelPrix.Text = "Prix de livre";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Tan;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnuler.Location = new System.Drawing.Point(454, 198);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(62, 26);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 289);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.labeltitre);
            this.Controls.Add(this.labelliste);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.ListeLivre);
            this.Name = "Form1";
            this.Text = "Formulaire";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListeLivre;
        private System.Windows.Forms.TextBox titre;
        private System.Windows.Forms.TextBox prix;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label labelliste;
        private System.Windows.Forms.Label labeltitre;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Button btnAnnuler;
    }
}

