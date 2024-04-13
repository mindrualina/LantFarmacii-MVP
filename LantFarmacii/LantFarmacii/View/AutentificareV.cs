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

namespace LantFarmacii.View
{
    public partial class AutentificareV : Form, IAutentificare
    {

        public AutentificareV()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Environment.Exit(0);
        }

        public string AccesParola()
        {
            return this.txtParolaAutentificare.Text;
        }

        public string AccesUser()
        {
            return this.txtUserAutentificare.Text;
        }

        public void ActualizareParola()
        {
            this.txtParolaAutentificare.Text = "";
        }

        public void ActualizareUser()
        {
            this.txtUserAutentificare.Text = "";
        }

        public void ActualizareVizualizare()
        {
            this.Hide();
        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            AutentificareP aP = new AutentificareP(this);
            aP.Logare();
            this.Hide();
        }

        private void txtUserAutentificare_TextChanged(object sender, EventArgs e)
        {

        }

        private void AutentificareV_Load(object sender, EventArgs e)
        {

        }
    }
}
