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
    public partial class Manager : Form, IManager
    {

        private ManagerP autoP;
        public Manager()
        {
            InitializeComponent();
            this.autoP = new ManagerP(this);
        }

        private void Deconectare_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutentificareV autentificareV = new AutentificareV();
            autentificareV.Show();
        }

        private void btnAfisareLista_Click(object sender, EventArgs e)
        {
            this.autoP.VizualizareListaMedicamente();
        }

        

        public int AccesareFiltruSelectat()
        {
            return this.cmbFiltrare.SelectedIndex;
        }

        public string AccesFiltrare()
        {
            return this.txtFiltrare.Text;
        }

        public void ActualizareListaMedicamente(List<DataGridViewRow> lista)
        {
            this.dataGridView1.Rows.Clear();
            foreach (DataGridViewRow rand in lista)
                this.dataGridView1.Rows.Add(rand);
        }

        private void cmbFiltrare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrare_Click(object sender, EventArgs e)
        {
            ManagerP mP = new ManagerP(this);
            mP.VizualizareListaMedicamenteFiltrate();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
