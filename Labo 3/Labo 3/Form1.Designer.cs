namespace Labo_3
{
   partial class Form1
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
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.groupBox4 = new System.Windows.Forms.GroupBox();
         this.groupBox5 = new System.Windows.Forms.GroupBox();
         this.TB_InsertNumEmp = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.TB_InsertNomEmp = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.TB_InsertPrenomEmp = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.TB_InsertSalEmp = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.TB_InsertCodeDep = new System.Windows.Forms.TextBox();
         this.BTN_Insert = new System.Windows.Forms.Button();
         this.DGV_Recherche = new System.Windows.Forms.DataGridView();
         this.label6 = new System.Windows.Forms.Label();
         this.TB_RechercheNom = new System.Windows.Forms.TextBox();
         this.BTN_Recherche = new System.Windows.Forms.Button();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.BTN_Lister = new System.Windows.Forms.Button();
         this.TB_ListerNom = new System.Windows.Forms.TextBox();
         this.label7 = new System.Windows.Forms.Label();
         this.DGV_Lister = new System.Windows.Forms.DataGridView();
         this.BTN_Supprimer = new System.Windows.Forms.Button();
         this.TB_SupprimerNumEmp = new System.Windows.Forms.TextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.TB_SalNumEmp = new System.Windows.Forms.TextBox();
         this.label10 = new System.Windows.Forms.Label();
         this.TB_SalModif = new System.Windows.Forms.TextBox();
         this.BTN_Sal = new System.Windows.Forms.Button();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox4.SuspendLayout();
         this.groupBox5.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.DGV_Recherche)).BeginInit();
         this.groupBox3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.DGV_Lister)).BeginInit();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.BTN_Insert);
         this.groupBox1.Controls.Add(this.label5);
         this.groupBox1.Controls.Add(this.TB_InsertCodeDep);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.TB_InsertSalEmp);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.TB_InsertPrenomEmp);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.TB_InsertNomEmp);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.TB_InsertNumEmp);
         this.groupBox1.Location = new System.Drawing.Point(12, 201);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(194, 184);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Insertion";
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.BTN_Recherche);
         this.groupBox2.Controls.Add(this.TB_RechercheNom);
         this.groupBox2.Controls.Add(this.label6);
         this.groupBox2.Controls.Add(this.DGV_Recherche);
         this.groupBox2.Location = new System.Drawing.Point(212, 12);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(194, 184);
         this.groupBox2.TabIndex = 1;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Recherche";
         // 
         // groupBox4
         // 
         this.groupBox4.Controls.Add(this.label8);
         this.groupBox4.Controls.Add(this.TB_SupprimerNumEmp);
         this.groupBox4.Controls.Add(this.BTN_Supprimer);
         this.groupBox4.Location = new System.Drawing.Point(212, 202);
         this.groupBox4.Name = "groupBox4";
         this.groupBox4.Size = new System.Drawing.Size(194, 78);
         this.groupBox4.TabIndex = 1;
         this.groupBox4.TabStop = false;
         this.groupBox4.Text = "Supprimer";
         // 
         // groupBox5
         // 
         this.groupBox5.Controls.Add(this.BTN_Sal);
         this.groupBox5.Controls.Add(this.label10);
         this.groupBox5.Controls.Add(this.TB_SalModif);
         this.groupBox5.Controls.Add(this.label9);
         this.groupBox5.Controls.Add(this.TB_SalNumEmp);
         this.groupBox5.Location = new System.Drawing.Point(212, 286);
         this.groupBox5.Name = "groupBox5";
         this.groupBox5.Size = new System.Drawing.Size(194, 100);
         this.groupBox5.TabIndex = 1;
         this.groupBox5.TabStop = false;
         this.groupBox5.Text = "Modifier salaire";
         // 
         // TB_InsertNumEmp
         // 
         this.TB_InsertNumEmp.Location = new System.Drawing.Point(83, 19);
         this.TB_InsertNumEmp.Name = "TB_InsertNumEmp";
         this.TB_InsertNumEmp.Size = new System.Drawing.Size(100, 20);
         this.TB_InsertNumEmp.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(21, 22);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(56, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "NumEmp :";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(21, 48);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(56, 13);
         this.label2.TabIndex = 3;
         this.label2.Text = "NomEmp :";
         // 
         // TB_InsertNomEmp
         // 
         this.TB_InsertNomEmp.Location = new System.Drawing.Point(83, 45);
         this.TB_InsertNomEmp.Name = "TB_InsertNomEmp";
         this.TB_InsertNomEmp.Size = new System.Drawing.Size(100, 20);
         this.TB_InsertNomEmp.TabIndex = 2;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(7, 74);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(70, 13);
         this.label3.TabIndex = 5;
         this.label3.Text = "PrenomEmp :";
         // 
         // TB_InsertPrenomEmp
         // 
         this.TB_InsertPrenomEmp.Location = new System.Drawing.Point(83, 71);
         this.TB_InsertPrenomEmp.Name = "TB_InsertPrenomEmp";
         this.TB_InsertPrenomEmp.Size = new System.Drawing.Size(100, 20);
         this.TB_InsertPrenomEmp.TabIndex = 4;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(11, 100);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(66, 13);
         this.label4.TabIndex = 7;
         this.label4.Text = "SalaireEmp :";
         // 
         // TB_InsertSalEmp
         // 
         this.TB_InsertSalEmp.Location = new System.Drawing.Point(83, 97);
         this.TB_InsertSalEmp.Name = "TB_InsertSalEmp";
         this.TB_InsertSalEmp.Size = new System.Drawing.Size(100, 20);
         this.TB_InsertSalEmp.TabIndex = 6;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(19, 126);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(58, 13);
         this.label5.TabIndex = 9;
         this.label5.Text = "CodeDep :";
         // 
         // TB_InsertCodeDep
         // 
         this.TB_InsertCodeDep.Location = new System.Drawing.Point(83, 123);
         this.TB_InsertCodeDep.Name = "TB_InsertCodeDep";
         this.TB_InsertCodeDep.Size = new System.Drawing.Size(100, 20);
         this.TB_InsertCodeDep.TabIndex = 8;
         // 
         // BTN_Insert
         // 
         this.BTN_Insert.Location = new System.Drawing.Point(10, 149);
         this.BTN_Insert.Name = "BTN_Insert";
         this.BTN_Insert.Size = new System.Drawing.Size(173, 23);
         this.BTN_Insert.TabIndex = 10;
         this.BTN_Insert.Text = "Ajouter";
         this.BTN_Insert.UseVisualStyleBackColor = true;
         // 
         // DGV_Recherche
         // 
         this.DGV_Recherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.DGV_Recherche.Location = new System.Drawing.Point(6, 45);
         this.DGV_Recherche.Name = "DGV_Recherche";
         this.DGV_Recherche.Size = new System.Drawing.Size(182, 133);
         this.DGV_Recherche.TabIndex = 0;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(9, 22);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(35, 13);
         this.label6.TabIndex = 1;
         this.label6.Text = "Nom :";
         // 
         // TB_RechercheNom
         // 
         this.TB_RechercheNom.Location = new System.Drawing.Point(50, 19);
         this.TB_RechercheNom.Name = "TB_RechercheNom";
         this.TB_RechercheNom.Size = new System.Drawing.Size(61, 20);
         this.TB_RechercheNom.TabIndex = 2;
         // 
         // BTN_Recherche
         // 
         this.BTN_Recherche.Location = new System.Drawing.Point(117, 17);
         this.BTN_Recherche.Name = "BTN_Recherche";
         this.BTN_Recherche.Size = new System.Drawing.Size(71, 23);
         this.BTN_Recherche.TabIndex = 3;
         this.BTN_Recherche.Text = "GO";
         this.BTN_Recherche.UseVisualStyleBackColor = true;
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.BTN_Lister);
         this.groupBox3.Controls.Add(this.TB_ListerNom);
         this.groupBox3.Controls.Add(this.label7);
         this.groupBox3.Controls.Add(this.DGV_Lister);
         this.groupBox3.Location = new System.Drawing.Point(12, 11);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(194, 184);
         this.groupBox3.TabIndex = 4;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Lister";
         // 
         // BTN_Lister
         // 
         this.BTN_Lister.Location = new System.Drawing.Point(128, 17);
         this.BTN_Lister.Name = "BTN_Lister";
         this.BTN_Lister.Size = new System.Drawing.Size(60, 23);
         this.BTN_Lister.TabIndex = 3;
         this.BTN_Lister.Text = "GO";
         this.BTN_Lister.UseVisualStyleBackColor = true;
         // 
         // TB_ListerNom
         // 
         this.TB_ListerNom.Location = new System.Drawing.Point(73, 19);
         this.TB_ListerNom.Name = "TB_ListerNom";
         this.TB_ListerNom.Size = new System.Drawing.Size(49, 20);
         this.TB_ListerNom.TabIndex = 2;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(9, 22);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(58, 13);
         this.label7.TabIndex = 1;
         this.label7.Text = "CodeDep :";
         // 
         // DGV_Lister
         // 
         this.DGV_Lister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.DGV_Lister.Location = new System.Drawing.Point(6, 45);
         this.DGV_Lister.Name = "DGV_Lister";
         this.DGV_Lister.Size = new System.Drawing.Size(182, 133);
         this.DGV_Lister.TabIndex = 0;
         // 
         // BTN_Supprimer
         // 
         this.BTN_Supprimer.Location = new System.Drawing.Point(6, 46);
         this.BTN_Supprimer.Name = "BTN_Supprimer";
         this.BTN_Supprimer.Size = new System.Drawing.Size(182, 23);
         this.BTN_Supprimer.TabIndex = 0;
         this.BTN_Supprimer.Text = "Supprimer";
         this.BTN_Supprimer.UseVisualStyleBackColor = true;
         // 
         // TB_SupprimerNumEmp
         // 
         this.TB_SupprimerNumEmp.Location = new System.Drawing.Point(71, 20);
         this.TB_SupprimerNumEmp.Name = "TB_SupprimerNumEmp";
         this.TB_SupprimerNumEmp.Size = new System.Drawing.Size(117, 20);
         this.TB_SupprimerNumEmp.TabIndex = 1;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(9, 23);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(56, 13);
         this.label8.TabIndex = 2;
         this.label8.Text = "NumEmp :";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(42, 22);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(56, 13);
         this.label9.TabIndex = 9;
         this.label9.Text = "NumEmp :";
         // 
         // TB_SalNumEmp
         // 
         this.TB_SalNumEmp.Location = new System.Drawing.Point(104, 19);
         this.TB_SalNumEmp.Name = "TB_SalNumEmp";
         this.TB_SalNumEmp.Size = new System.Drawing.Size(84, 20);
         this.TB_SalNumEmp.TabIndex = 8;
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(6, 48);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(92, 13);
         this.label10.TabIndex = 11;
         this.label10.Text = "Nouveau Salaire :";
         // 
         // TB_SalModif
         // 
         this.TB_SalModif.Location = new System.Drawing.Point(104, 45);
         this.TB_SalModif.Name = "TB_SalModif";
         this.TB_SalModif.Size = new System.Drawing.Size(84, 20);
         this.TB_SalModif.TabIndex = 10;
         // 
         // BTN_Sal
         // 
         this.BTN_Sal.Location = new System.Drawing.Point(6, 71);
         this.BTN_Sal.Name = "BTN_Sal";
         this.BTN_Sal.Size = new System.Drawing.Size(182, 23);
         this.BTN_Sal.TabIndex = 3;
         this.BTN_Sal.Text = "Supprimer";
         this.BTN_Sal.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(419, 399);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.groupBox5);
         this.Controls.Add(this.groupBox4);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
         this.Load += new System.EventHandler(this.Form1_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.groupBox4.ResumeLayout(false);
         this.groupBox4.PerformLayout();
         this.groupBox5.ResumeLayout(false);
         this.groupBox5.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.DGV_Recherche)).EndInit();
         this.groupBox3.ResumeLayout(false);
         this.groupBox3.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.DGV_Lister)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button BTN_Insert;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox TB_InsertCodeDep;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox TB_InsertSalEmp;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox TB_InsertPrenomEmp;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox TB_InsertNomEmp;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox TB_InsertNumEmp;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.GroupBox groupBox4;
      private System.Windows.Forms.GroupBox groupBox5;
      private System.Windows.Forms.DataGridView DGV_Recherche;
      private System.Windows.Forms.Button BTN_Recherche;
      private System.Windows.Forms.TextBox TB_RechercheNom;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.Button BTN_Lister;
      private System.Windows.Forms.TextBox TB_ListerNom;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.DataGridView DGV_Lister;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.TextBox TB_SupprimerNumEmp;
      private System.Windows.Forms.Button BTN_Supprimer;
      private System.Windows.Forms.Button BTN_Sal;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.TextBox TB_SalModif;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.TextBox TB_SalNumEmp;
   }
}

