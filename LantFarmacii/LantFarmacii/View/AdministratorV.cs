using LantFarmacii.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LantFarmacii.View
{
    public partial class AdministratorV : Form, IAdministrator
    {

        private AdministratorP admP;
        public AdministratorV()
        {
            InitializeComponent();
            this.admP = new AdministratorP(this);
        }

        string IAdministrator.AccesLegitimatie()
        {
            return this.txtID.Text;
        }

        int IAdministrator.AccesLegitimatieSelectata()
        {
            if (this.dataGridView1.GetCellCount(DataGridViewElementStates.Selected) > 0)
                return Convert.ToInt32(this.dataGridView1.SelectedCells[0].Value);
            else
                return -1;
        }

        string IAdministrator.AccesNume()
        {
            return this.txtNume.Text;
        }

        string IAdministrator.AccesParola()
        {
            return this.txtParola.Text;

        }

        int IAdministrator.AccesRolSelectat()
        {
            return this.cmbRolU.SelectedIndex;
        }

        string IAdministrator.AccesUser()
        {
            return this.txtUser.Text;
        }

        void IAdministrator.ActualizareListaUtilizatori(List<DataGridViewRow> lista)
        {
            this.dataGridView1.Rows.Clear();
            foreach (DataGridViewRow rand in lista)
                this.dataGridView1.Rows.Add(rand);
        }

        private void AdministratorV_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdaugaUtilizator_Click(object sender, EventArgs e)
        {
            this.admP.AdaugareUtilizator();
        }

        private void btnActualizareUtilizator_Click(object sender, EventArgs e)
        {
            this.admP.ActualizareaUtilizator();

        }

        private void btnStergereUtilizator_Click(object sender, EventArgs e)
        {
            this.admP.StergereUtilizator();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            this.admP.VizualizareLista();
        }

        private void btnDeconectare_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutentificareV autentificareV = new AutentificareV();
            autentificareV.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
