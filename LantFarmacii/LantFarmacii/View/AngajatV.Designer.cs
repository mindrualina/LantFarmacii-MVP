namespace LantFarmacii
{
    partial class AngajatV
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
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtValabilitate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdaugaMed = new System.Windows.Forms.Button();
            this.btnActualizareMed = new System.Windows.Forms.Button();
            this.btnStergereMed = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denumire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibilitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataValabilitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListaMed = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCautaDupaDenumire = new System.Windows.Forms.TextBox();
            this.btnCautaDupaProprietar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtFiltrare = new System.Windows.Forms.TextBox();
            this.btnFiltrare = new System.Windows.Forms.Button();
            this.Deconectare = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProducator = new System.Windows.Forms.TextBox();
            this.txtDisponibilitate = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(169, 92);
            this.txtDenumire.Margin = new System.Windows.Forms.Padding(2);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(104, 20);
            this.txtDenumire.TabIndex = 0;
            this.txtDenumire.TextChanged += new System.EventHandler(this.txtProprietar_TextChanged);
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(169, 171);
            this.txtPret.Margin = new System.Windows.Forms.Padding(2);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(104, 20);
            this.txtPret.TabIndex = 1;
            this.txtPret.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // txtValabilitate
            // 
            this.txtValabilitate.Location = new System.Drawing.Point(169, 213);
            this.txtValabilitate.Margin = new System.Windows.Forms.Padding(2);
            this.txtValabilitate.Name = "txtValabilitate";
            this.txtValabilitate.Size = new System.Drawing.Size(104, 20);
            this.txtValabilitate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Denumire";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "DataValabilitate";
            // 
            // btnAdaugaMed
            // 
            this.btnAdaugaMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaMed.Location = new System.Drawing.Point(332, 33);
            this.btnAdaugaMed.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdaugaMed.Name = "btnAdaugaMed";
            this.btnAdaugaMed.Size = new System.Drawing.Size(101, 68);
            this.btnAdaugaMed.TabIndex = 8;
            this.btnAdaugaMed.Text = "Adauga Medicament";
            this.btnAdaugaMed.UseVisualStyleBackColor = true;
            this.btnAdaugaMed.Click += new System.EventHandler(this.btnAdaugaMed_Click);
            // 
            // btnActualizareMed
            // 
            this.btnActualizareMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizareMed.Location = new System.Drawing.Point(332, 124);
            this.btnActualizareMed.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizareMed.Name = "btnActualizareMed";
            this.btnActualizareMed.Size = new System.Drawing.Size(101, 69);
            this.btnActualizareMed.TabIndex = 9;
            this.btnActualizareMed.Text = "Actualizare Medicament";
            this.btnActualizareMed.UseVisualStyleBackColor = true;
            this.btnActualizareMed.Click += new System.EventHandler(this.btnActualizareMed_Click);
            // 
            // btnStergereMed
            // 
            this.btnStergereMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergereMed.Location = new System.Drawing.Point(332, 235);
            this.btnStergereMed.Margin = new System.Windows.Forms.Padding(2);
            this.btnStergereMed.Name = "btnStergereMed";
            this.btnStergereMed.Size = new System.Drawing.Size(101, 56);
            this.btnStergereMed.TabIndex = 10;
            this.btnStergereMed.Text = "Stergere Medicament";
            this.btnStergereMed.UseVisualStyleBackColor = true;
            this.btnStergereMed.Click += new System.EventHandler(this.btnStergereMed_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD,
            this.Denumire,
            this.Disponibilitate,
            this.Pret,
            this.DataValabilitate,
            this.Producator});
            this.dataGridView1.Location = new System.Drawing.Point(194, 351);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 297);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // COD
            // 
            this.COD.HeaderText = "COD";
            this.COD.Name = "COD";
            // 
            // Denumire
            // 
            this.Denumire.HeaderText = "Denumire";
            this.Denumire.MinimumWidth = 6;
            this.Denumire.Name = "Denumire";
            this.Denumire.Width = 125;
            // 
            // Disponibilitate
            // 
            this.Disponibilitate.HeaderText = "Disponibilitate";
            this.Disponibilitate.Name = "Disponibilitate";
            // 
            // Pret
            // 
            this.Pret.HeaderText = "Pret";
            this.Pret.MinimumWidth = 6;
            this.Pret.Name = "Pret";
            this.Pret.Width = 125;
            // 
            // DataValabilitate
            // 
            this.DataValabilitate.HeaderText = "DataValabilitate";
            this.DataValabilitate.MinimumWidth = 6;
            this.DataValabilitate.Name = "DataValabilitate";
            this.DataValabilitate.Width = 125;
            // 
            // Producator
            // 
            this.Producator.HeaderText = "Producator";
            this.Producator.Name = "Producator";
            // 
            // btnListaMed
            // 
            this.btnListaMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaMed.Location = new System.Drawing.Point(759, 46);
            this.btnListaMed.Margin = new System.Windows.Forms.Padding(2);
            this.btnListaMed.Name = "btnListaMed";
            this.btnListaMed.Size = new System.Drawing.Size(145, 42);
            this.btnListaMed.TabIndex = 12;
            this.btnListaMed.Text = "Lista Medicamente";
            this.btnListaMed.UseVisualStyleBackColor = true;
            this.btnListaMed.Click += new System.EventHandler(this.btnListaMed_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(634, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cautare dupa denumire";
            // 
            // txtCautaDupaDenumire
            // 
            this.txtCautaDupaDenumire.Location = new System.Drawing.Point(637, 159);
            this.txtCautaDupaDenumire.Margin = new System.Windows.Forms.Padding(2);
            this.txtCautaDupaDenumire.Name = "txtCautaDupaDenumire";
            this.txtCautaDupaDenumire.Size = new System.Drawing.Size(113, 20);
            this.txtCautaDupaDenumire.TabIndex = 14;
            this.txtCautaDupaDenumire.TextChanged += new System.EventHandler(this.txtCautaDupaProprietar_TextChanged);
            // 
            // btnCautaDupaProprietar
            // 
            this.btnCautaDupaProprietar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautaDupaProprietar.Location = new System.Drawing.Point(637, 201);
            this.btnCautaDupaProprietar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCautaDupaProprietar.Name = "btnCautaDupaProprietar";
            this.btnCautaDupaProprietar.Size = new System.Drawing.Size(85, 36);
            this.btnCautaDupaProprietar.TabIndex = 15;
            this.btnCautaDupaProprietar.Text = "Cauta";
            this.btnCautaDupaProprietar.UseVisualStyleBackColor = true;
            this.btnCautaDupaProprietar.Click += new System.EventHandler(this.btnCautaDupaDenumire_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(924, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Filtre";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "toata lista",
            "disponibiltate",
            "valabilitate",
            "pret",
            "producator"});
            this.comboBox1.Location = new System.Drawing.Point(895, 151);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // txtFiltrare
            // 
            this.txtFiltrare.Location = new System.Drawing.Point(895, 200);
            this.txtFiltrare.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltrare.Name = "txtFiltrare";
            this.txtFiltrare.Size = new System.Drawing.Size(115, 20);
            this.txtFiltrare.TabIndex = 18;
            // 
            // btnFiltrare
            // 
            this.btnFiltrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrare.Location = new System.Drawing.Point(912, 243);
            this.btnFiltrare.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrare.Name = "btnFiltrare";
            this.btnFiltrare.Size = new System.Drawing.Size(83, 40);
            this.btnFiltrare.TabIndex = 19;
            this.btnFiltrare.Text = "Filtrare";
            this.btnFiltrare.UseVisualStyleBackColor = true;
            this.btnFiltrare.Click += new System.EventHandler(this.button6_Click);
            // 
            // Deconectare
            // 
            this.Deconectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deconectare.Location = new System.Drawing.Point(1036, 625);
            this.Deconectare.Margin = new System.Windows.Forms.Padding(2);
            this.Deconectare.Name = "Deconectare";
            this.Deconectare.Size = new System.Drawing.Size(103, 40);
            this.Deconectare.TabIndex = 20;
            this.Deconectare.Text = "Deconectare";
            this.Deconectare.UseVisualStyleBackColor = true;
            this.Deconectare.Click += new System.EventHandler(this.Deconectare_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // txtCod
            // 
            this.txtCod.AutoSize = true;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(83, 46);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(36, 16);
            this.txtCod.TabIndex = 23;
            this.txtCod.Text = "COD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Disponibilitate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Producator";
            // 
            // txtProducator
            // 
            this.txtProducator.Location = new System.Drawing.Point(173, 256);
            this.txtProducator.Name = "txtProducator";
            this.txtProducator.Size = new System.Drawing.Size(100, 20);
            this.txtProducator.TabIndex = 27;
            // 
            // txtDisponibilitate
            // 
            this.txtDisponibilitate.FormattingEnabled = true;
            this.txtDisponibilitate.Items.AddRange(new object[] {
            "",
            "NU",
            "DA"});
            this.txtDisponibilitate.Location = new System.Drawing.Point(169, 132);
            this.txtDisponibilitate.Name = "txtDisponibilitate";
            this.txtDisponibilitate.Size = new System.Drawing.Size(104, 21);
            this.txtDisponibilitate.TabIndex = 28;
            // 
            // AngajatV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1162, 694);
            this.Controls.Add(this.txtDisponibilitate);
            this.Controls.Add(this.txtProducator);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Deconectare);
            this.Controls.Add(this.btnFiltrare);
            this.Controls.Add(this.txtFiltrare);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCautaDupaProprietar);
            this.Controls.Add(this.txtCautaDupaDenumire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnListaMed);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStergereMed);
            this.Controls.Add(this.btnActualizareMed);
            this.Controls.Add(this.btnAdaugaMed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValabilitate);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtDenumire);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AngajatV";
            this.Text = "AngajatV";
            this.Load += new System.EventHandler(this.AngajatV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtValabilitate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdaugaMed;
        private System.Windows.Forms.Button btnActualizareMed;
        private System.Windows.Forms.Button btnStergereMed;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListaMed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCautaDupaDenumire;
        private System.Windows.Forms.Button btnCautaDupaProprietar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtFiltrare;
        private System.Windows.Forms.Button btnFiltrare;
        private System.Windows.Forms.Button Deconectare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtCod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProducator;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denumire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponibilitate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataValabilitate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producator;
        private System.Windows.Forms.ComboBox txtDisponibilitate;
    }
}