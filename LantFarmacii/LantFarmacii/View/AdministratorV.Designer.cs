namespace LantFarmacii.View
{
    partial class AdministratorV
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
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.cmbRolU = new System.Windows.Forms.ComboBox();
            this.btnAdaugaUtilizator = new System.Windows.Forms.Button();
            this.btnActualizareUtilizator = new System.Windows.Forms.Button();
            this.btnStergereUtilizator = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnDeconectare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(55, 34);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 16);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "USER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "PAROLA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "ROL";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(117, 34);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(92, 20);
            this.txtID.TabIndex = 5;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(117, 76);
            this.txtNume.Margin = new System.Windows.Forms.Padding(2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(92, 20);
            this.txtNume.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(117, 120);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(92, 20);
            this.txtUser.TabIndex = 7;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(117, 167);
            this.txtParola.Margin = new System.Windows.Forms.Padding(2);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(92, 20);
            this.txtParola.TabIndex = 8;
            // 
            // cmbRolU
            // 
            this.cmbRolU.FormattingEnabled = true;
            this.cmbRolU.Items.AddRange(new object[] {
            "",
            "ANGAJAT",
            "MANAGER",
            "ADMINISTRATOR"});
            this.cmbRolU.Location = new System.Drawing.Point(117, 212);
            this.cmbRolU.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRolU.Name = "cmbRolU";
            this.cmbRolU.Size = new System.Drawing.Size(92, 21);
            this.cmbRolU.TabIndex = 9;
            // 
            // btnAdaugaUtilizator
            // 
            this.btnAdaugaUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaUtilizator.Location = new System.Drawing.Point(241, 34);
            this.btnAdaugaUtilizator.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdaugaUtilizator.Name = "btnAdaugaUtilizator";
            this.btnAdaugaUtilizator.Size = new System.Drawing.Size(85, 62);
            this.btnAdaugaUtilizator.TabIndex = 10;
            this.btnAdaugaUtilizator.Text = "Adaugare Utilizator";
            this.btnAdaugaUtilizator.UseVisualStyleBackColor = true;
            this.btnAdaugaUtilizator.Click += new System.EventHandler(this.btnAdaugaUtilizator_Click);
            // 
            // btnActualizareUtilizator
            // 
            this.btnActualizareUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizareUtilizator.Location = new System.Drawing.Point(237, 120);
            this.btnActualizareUtilizator.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizareUtilizator.Name = "btnActualizareUtilizator";
            this.btnActualizareUtilizator.Size = new System.Drawing.Size(89, 67);
            this.btnActualizareUtilizator.TabIndex = 11;
            this.btnActualizareUtilizator.Text = "Actualizare Utilizator";
            this.btnActualizareUtilizator.UseVisualStyleBackColor = true;
            this.btnActualizareUtilizator.Click += new System.EventHandler(this.btnActualizareUtilizator_Click);
            // 
            // btnStergereUtilizator
            // 
            this.btnStergereUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergereUtilizator.Location = new System.Drawing.Point(237, 212);
            this.btnStergereUtilizator.Margin = new System.Windows.Forms.Padding(2);
            this.btnStergereUtilizator.Name = "btnStergereUtilizator";
            this.btnStergereUtilizator.Size = new System.Drawing.Size(89, 61);
            this.btnStergereUtilizator.TabIndex = 12;
            this.btnStergereUtilizator.Text = "Stergere Utilizator";
            this.btnStergereUtilizator.UseVisualStyleBackColor = true;
            this.btnStergereUtilizator.Click += new System.EventHandler(this.btnStergereUtilizator_Click);
            // 
            // btnLista
            // 
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.Location = new System.Drawing.Point(99, 338);
            this.btnLista.Margin = new System.Windows.Forms.Padding(2);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(155, 40);
            this.btnLista.TabIndex = 13;
            this.btnLista.Text = "Afisare Lista Utilizatori";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnDeconectare
            // 
            this.btnDeconectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconectare.Location = new System.Drawing.Point(846, 451);
            this.btnDeconectare.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeconectare.Name = "btnDeconectare";
            this.btnDeconectare.Size = new System.Drawing.Size(101, 46);
            this.btnDeconectare.TabIndex = 14;
            this.btnDeconectare.Text = "Deconectare";
            this.btnDeconectare.UseVisualStyleBackColor = true;
            this.btnDeconectare.Click += new System.EventHandler(this.btnDeconectare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDut,
            this.Nume,
            this.User,
            this.Parola,
            this.Rol});
            this.dataGridView1.Location = new System.Drawing.Point(368, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(676, 293);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IDut
            // 
            this.IDut.HeaderText = "ID";
            this.IDut.MinimumWidth = 6;
            this.IDut.Name = "IDut";
            this.IDut.Width = 125;
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.MinimumWidth = 6;
            this.Nume.Name = "Nume";
            this.Nume.Width = 125;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            this.User.Width = 125;
            // 
            // Parola
            // 
            this.Parola.HeaderText = "Parola";
            this.Parola.MinimumWidth = 6;
            this.Parola.Name = "Parola";
            this.Parola.Width = 125;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.Width = 125;
            // 
            // AdministratorV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1090, 563);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeconectare);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnStergereUtilizator);
            this.Controls.Add(this.btnActualizareUtilizator);
            this.Controls.Add(this.btnAdaugaUtilizator);
            this.Controls.Add(this.cmbRolU);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdministratorV";
            this.Text = "AdministratorV";
            this.Load += new System.EventHandler(this.AdministratorV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.ComboBox cmbRolU;
        private System.Windows.Forms.Button btnAdaugaUtilizator;
        private System.Windows.Forms.Button btnActualizareUtilizator;
        private System.Windows.Forms.Button btnStergereUtilizator;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnDeconectare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
    }
}