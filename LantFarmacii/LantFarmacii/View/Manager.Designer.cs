namespace LantFarmacii.View
{
    partial class Manager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAfisareLista = new System.Windows.Forms.Button();
            this.Deconectare = new System.Windows.Forms.Button();
            this.btnFiltrare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFiltrare = new System.Windows.Forms.ComboBox();
            this.txtFiltrare = new System.Windows.Forms.TextBox();
            this.COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denumire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibilitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valabilitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.Valabilitate,
            this.Producator});
            this.dataGridView1.Location = new System.Drawing.Point(284, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAfisareLista
            // 
            this.btnAfisareLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfisareLista.Location = new System.Drawing.Point(45, 116);
            this.btnAfisareLista.Margin = new System.Windows.Forms.Padding(2);
            this.btnAfisareLista.Name = "btnAfisareLista";
            this.btnAfisareLista.Size = new System.Drawing.Size(148, 65);
            this.btnAfisareLista.TabIndex = 1;
            this.btnAfisareLista.Text = "Afiseaza lista";
            this.btnAfisareLista.UseVisualStyleBackColor = true;
            this.btnAfisareLista.Click += new System.EventHandler(this.btnAfisareLista_Click);
            // 
            // Deconectare
            // 
            this.Deconectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deconectare.Location = new System.Drawing.Point(860, 528);
            this.Deconectare.Margin = new System.Windows.Forms.Padding(2);
            this.Deconectare.Name = "Deconectare";
            this.Deconectare.Size = new System.Drawing.Size(151, 46);
            this.Deconectare.TabIndex = 2;
            this.Deconectare.Text = "Deconectare";
            this.Deconectare.UseVisualStyleBackColor = true;
            this.Deconectare.Click += new System.EventHandler(this.Deconectare_Click);
            // 
            // btnFiltrare
            // 
            this.btnFiltrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrare.Location = new System.Drawing.Point(486, 472);
            this.btnFiltrare.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrare.Name = "btnFiltrare";
            this.btnFiltrare.Size = new System.Drawing.Size(99, 39);
            this.btnFiltrare.TabIndex = 3;
            this.btnFiltrare.Text = "Filtrare";
            this.btnFiltrare.UseVisualStyleBackColor = true;
            this.btnFiltrare.Click += new System.EventHandler(this.btnFiltrare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtre";
            // 
            // cmbFiltrare
            // 
            this.cmbFiltrare.FormattingEnabled = true;
            this.cmbFiltrare.Items.AddRange(new object[] {
            "Toata Lista",
            "Disponibilitate",
            "Valabilitate",
            "Pret",
            "Producator"});
            this.cmbFiltrare.Location = new System.Drawing.Point(486, 383);
            this.cmbFiltrare.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFiltrare.Name = "cmbFiltrare";
            this.cmbFiltrare.Size = new System.Drawing.Size(92, 21);
            this.cmbFiltrare.TabIndex = 6;
            this.cmbFiltrare.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrare_SelectedIndexChanged);
            // 
            // txtFiltrare
            // 
            this.txtFiltrare.Location = new System.Drawing.Point(486, 427);
            this.txtFiltrare.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltrare.Name = "txtFiltrare";
            this.txtFiltrare.Size = new System.Drawing.Size(92, 20);
            this.txtFiltrare.TabIndex = 7;
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
            // Valabilitate
            // 
            this.Valabilitate.HeaderText = "Valabilitate";
            this.Valabilitate.MinimumWidth = 6;
            this.Valabilitate.Name = "Valabilitate";
            this.Valabilitate.Width = 125;
            // 
            // Producator
            // 
            this.Producator.HeaderText = "Producator";
            this.Producator.Name = "Producator";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1066, 605);
            this.Controls.Add(this.txtFiltrare);
            this.Controls.Add(this.cmbFiltrare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFiltrare);
            this.Controls.Add(this.Deconectare);
            this.Controls.Add(this.btnAfisareLista);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAfisareLista;
        private System.Windows.Forms.Button Deconectare;
        private System.Windows.Forms.Button btnFiltrare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFiltrare;
        private System.Windows.Forms.TextBox txtFiltrare;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denumire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponibilitate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valabilitate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producator;
    }
}