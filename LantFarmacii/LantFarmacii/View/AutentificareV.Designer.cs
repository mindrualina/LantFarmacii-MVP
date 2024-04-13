namespace LantFarmacii.View
{
    partial class AutentificareV
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
            this.txtUserAutentificare = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParolaAutentificare = new System.Windows.Forms.TextBox();
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER";
            // 
            // txtUserAutentificare
            // 
            this.txtUserAutentificare.Location = new System.Drawing.Point(116, 107);
            this.txtUserAutentificare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserAutentificare.Name = "txtUserAutentificare";
            this.txtUserAutentificare.Size = new System.Drawing.Size(143, 20);
            this.txtUserAutentificare.TabIndex = 3;
            this.txtUserAutentificare.TextChanged += new System.EventHandler(this.txtUserAutentificare_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PAROLA";
            // 
            // txtParolaAutentificare
            // 
            this.txtParolaAutentificare.Location = new System.Drawing.Point(116, 182);
            this.txtParolaAutentificare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtParolaAutentificare.Name = "txtParolaAutentificare";
            this.txtParolaAutentificare.PasswordChar = '*';
            this.txtParolaAutentificare.Size = new System.Drawing.Size(143, 20);
            this.txtParolaAutentificare.TabIndex = 4;
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.Location = new System.Drawing.Point(120, 246);
            this.btnAutentificare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(144, 37);
            this.btnAutentificare.TabIndex = 0;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.UseVisualStyleBackColor = true;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // AutentificareV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 367);
            this.Controls.Add(this.btnAutentificare);
            this.Controls.Add(this.txtParolaAutentificare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserAutentificare);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AutentificareV";
            this.Text = "AutentificareV";
            this.Load += new System.EventHandler(this.AutentificareV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserAutentificare;
        private System.Windows.Forms.TextBox txtParolaAutentificare;
    }
}