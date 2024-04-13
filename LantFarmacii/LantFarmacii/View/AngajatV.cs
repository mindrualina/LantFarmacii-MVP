
using LantFarmacii.Model;
using LantFarmacii.Presenter;
using LantFarmacii.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LantFarmacii
{
    public partial class AngajatV : Form, IAngajat
    {

        private AngajatP autoP;
        public AngajatV()
        {
            InitializeComponent();
            this.autoP = new AngajatP(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AngajatV_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AngajatP aP = new AngajatP(this);
            aP.VizualizareListaMedicamenteFiltrate();
        }

        public string AccesCodMedicament()
        {
            return this.txtCod.Text;
        }

        string IAngajat.AccesDenumire() { 
        
            return this.txtDenumire.Text;
        }

        string IAngajat.AccesPret()
        {
            return this.txtPret.Text;        }

        string IAngajat.AccesValabilitate()
        {
            return this.txtValabilitate.Text;
        }

        public string AccesProducator()
        {
            return this.txtProducator.Text;
        }

        public int AccesDisponibilitate()
        {
            return this.txtDisponibilitate.SelectedIndex;

        }



        public void ActualizareListaMedicamente(List<DataGridViewRow> lista)
        {
            this.dataGridView1.Rows.Clear();
            foreach (DataGridViewRow rand in lista)
                this.dataGridView1.Rows.Add(rand);
        }


        public int AccesCodMedicamentSelectat()
        {
            if (this.dataGridView1.GetCellCount(DataGridViewElementStates.Selected) > 0)
                return Convert.ToInt32(this.dataGridView1.SelectedCells[0].Value);
            else
                return -1;
        }


        int IAngajat.AccesareFiltruSelectat()
        {
            return this.comboBox1.SelectedIndex;
        }

        string IAngajat.AccesFiltrare()
        {
            return this.txtFiltrare.Text;
        }

        string IAngajat.AccesCautareDupaDenumire()
        {
            return this.txtCautaDupaDenumire.Text;
        }

        

        private void txtProprietar_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnStergereMed_Click(object sender, EventArgs e)
        {
            this.autoP.StergereMedicament();
        }

        private void btnAdaugaMed_Click(object sender, EventArgs e)
        {
            this.autoP.AdaugareMedicament();
        }

        private void btnActualizareMed_Click(object sender, EventArgs e)
        {
            this.autoP.ActualizareMedicament();     
        }

        private void Deconectare_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutentificareV autentificareV = new AutentificareV();
            autentificareV.Show();
        }

        private void btnListaMed_Click(object sender, EventArgs e)
        {
            this.autoP.VizualizareListaMedicamente();
        }

        private void btnCautaDupaDenumire_Click(object sender, EventArgs e)
        {
            AngajatP mednP = new AngajatP(this);
            mednP.VizualizareListaMedicamenteCautateDenumire();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCautaDupaProprietar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
