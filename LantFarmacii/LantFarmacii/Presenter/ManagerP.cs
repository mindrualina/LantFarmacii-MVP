using LantFarmacii.Model;
using LantFarmacii.Model.Repository;
using LantFarmacii.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LantFarmacii.Presenter
{
    public class ManagerP
    {


        private IManager medV;
        private MedicamentRepository medR;

        public ManagerP(IManager medV)
        {
            this.medV = medV;
            this.medR = new MedicamentRepository();
        }

        public void VizualizareListaMedicamente()
        {
            List<Medicament> lista = this.medR.ListaMedicamente();

            if (lista != null)
            {
                List<DataGridViewRow> randuri = new List<DataGridViewRow>();
                foreach (Medicament ut in lista)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesCodMedicament().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesDenumire() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesDisponibilitate() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesPret() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesValabilitate() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesProducator() });

                    randuri.Add(rand);
                }
                this.medV.ActualizareListaMedicamente(randuri);
            }
            else
                MessageBox.Show("Lista medicamentelor este vida!");
        }


        public void VizualizareListaMedicamenteFiltrate()
        {

            List<Medicament> lista = new List<Medicament>();
            int filtru = this.medV.AccesareFiltruSelectat();
            string textFiltru = this.medV.AccesFiltrare();
            string filtruSelectat = "";
            if (filtru > 0)
            {

                filtruSelectat = "disponibilitate";
                if (filtru == 2)
                    filtruSelectat = "valabilitate";
                if (filtru == 3)
                    filtruSelectat = "pret";
                if (filtru == 4)
                    filtruSelectat = "producator";

                if (medV.AccesFiltrare() == "")
                {
                    MessageBox.Show("Nu s-au introdus date pt. filtrare");
                }
                lista = this.medR.FiltrareMedicamente(filtruSelectat, textFiltru);
            }
            else
                lista = this.medR.ListaMedicamente();

            if (lista != null)
            {
                List<DataGridViewRow> randuri = new List<DataGridViewRow>();
                foreach (Medicament medicament in lista)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = medicament.AccesCodMedicament().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = medicament.AccesDenumire() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = medicament.AccesDisponibilitate() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = medicament.AccesPret() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = medicament.AccesValabilitate() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = medicament.AccesProducator() });
                    randuri.Add(rand);
                }
                this.medV.ActualizareListaMedicamente(randuri);
            }
            else
                MessageBox.Show("Lista medicamentelor este vida!");
        }
    }
}
