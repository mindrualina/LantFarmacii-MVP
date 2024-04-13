using LantFarmacii.Model;
using LantFarmacii.Model.Repository;
using LantFarmacii.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LantFarmacii.Presenter
{
    public class AngajatP
    {
        private IAngajat medV;

        private MedicamentRepository medP;

        public AngajatP(IAngajat medV)
        {
            this.medV = medV;
            this.medP = new MedicamentRepository();
        }


        public void VizualizareListaMedicamente()
        {
            List<Medicament> lista = this.medP.ListaMedicamente();

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


        public void AdaugareMedicament()
        {
            bool dateCorecte = true;
            int rolSelectat = this.medV.AccesDisponibilitate();




            if (rolSelectat < 0 || medV.AccesCodMedicament().Equals("") || medV.AccesDenumire().Equals("") ||
                medV.AccesProducator().Equals("") || medV.AccesPret().Equals("") || medV.AccesValabilitate().Equals(""))
            {
                dateCorecte = false;
                MessageBox.Show("Nu au fost introduse toate datele necesare!!");
            }
            else
            {

                uint cod_medicament;
                string disponibilitate = "DA";
                if (rolSelectat == 1)
                    disponibilitate = "NU";
                string codp = this.medV.AccesCodMedicament();

                if (disponibilitate == "")
                {
                    MessageBox.Show("Nu au fost introduse toate datele necesare");
                    dateCorecte = false;
                }

                bool conversie = uint.TryParse(codp, out cod_medicament);
                if (conversie)
                {
                    cod_medicament = Convert.ToUInt32(codp);
                    if (cod_medicament == 0)
                    {
                        dateCorecte = false;
                        MessageBox.Show("ID-ul nu poate fi 0!");
                    }
                }





                uint pret = 0;
                string denumire = this.medV.AccesDenumire();

                string producator = this.medV.AccesProducator();

                string valabilitate = this.medV.AccesValabilitate();

                int myInt;
                conversie = int.TryParse(medV.AccesPret(), out myInt);
                if (conversie == true)
                {
                    pret = Convert.ToUInt32(medV.AccesPret());
                    if (pret == 0)
                    {
                        MessageBox.Show("Pretul nu poate fi 0 !!!");
                        dateCorecte = false;
                    }

                }
                else
                {

                    MessageBox.Show("Pretul trebuie sa fie in cifre!");
                    dateCorecte = false;
                }


                if (dateCorecte)
                {
                    Medicament ut = new Medicament((int)cod_medicament, denumire, disponibilitate, pret, valabilitate, producator);
                    bool succes = this.medP.AdaugareMedicament(ut);
                    if (!succes)
                        MessageBox.Show("Eroare la adaugare!");
                    else
                        this.VizualizareListaMedicamente();
                }

            }


        }


        public void ActualizareMedicament()
        {
            int codmed = this.medV.AccesCodMedicamentSelectat();
            int rolSelectat = this.medV.AccesDisponibilitate();
            if (codmed == -1)
                MessageBox.Show("Nu s-a selectat niciun medicament!");
            else
            {

                bool dateCorecte = true;
                int dispSelectat = this.medV.AccesDisponibilitate();
                string disponibilitate;
                string txtCodMed;
                uint codMedNou;

                disponibilitate = "DA";
                if (rolSelectat == 1)
                    disponibilitate = "NU";




                txtCodMed = this.medV.AccesCodMedicament();

                bool conversie = uint.TryParse(txtCodMed, out codMedNou);
                if (conversie)
                {
                    codMedNou = Convert.ToUInt32(txtCodMed);
                    if (codMedNou == 0)
                    {
                        dateCorecte = false;
                        MessageBox.Show("ID-ul nu poate fi 0!");
                    }
                }
                if ((!Regex.IsMatch(txtCodMed, @"^\d+$")) && txtCodMed != "")
                {
                    MessageBox.Show("ID-ul trebuie sa fie compus din cifre!!!");
                    dateCorecte = false;
                }


                if (this.medP.CautareMedicament((int)codMedNou) != null)
                {
                    MessageBox.Show("Exista alt medicament cu acest cod!");
                    dateCorecte = false;
                }
                else
                {
                    if (codMedNou == 0)
                        codMedNou = (uint)codmed;
                    string denumire = this.medV.AccesDenumire();
                    uint pret;
                    string txtPret = medV.AccesPret();
                    DateTime dDate;



                    bool conversie2 = uint.TryParse(this.medV.AccesPret(), out pret);
                    if (conversie2)
                    {
                        pret = Convert.ToUInt32(this.medV.AccesPret());
                        if (pret == 0)
                        {
                            dateCorecte = false;
                            MessageBox.Show("Pretul nu poate fi 0!");
                        }
                    }
                    if ((!Regex.IsMatch(medV.AccesPret(), @"^\d+$")) && txtPret != "")
                    {
                        MessageBox.Show("Pretul trebuie sa fie compus din cifre!!!");
                        dateCorecte = false;
                    }

                    string producator = this.medV.AccesProducator();
                    string valabilitate = this.medV.AccesValabilitate();
                    if (dateCorecte)
                    {
                        Medicament ut = new Medicament((int)codMedNou, denumire, disponibilitate, pret, valabilitate, producator);
                        bool succes = this.medP.ActualizareMedicament(codmed, ut);
                        if (!succes)
                            MessageBox.Show("Eroare la actualizare!");
                        else
                            this.VizualizareListaMedicamente();
                    }
                }

            }


        }


        public void StergereMedicament()
        {
            int codmed = this.medV.AccesCodMedicamentSelectat();
            if (codmed == -1)
                MessageBox.Show("Nu s-a selectat niciun medicament!");
            else
            {
                bool succes = this.medP.StergereMedicament(codmed);
                if (!succes)
                    MessageBox.Show("Nu s-a efectuat stergerea!");
                else
                    this.VizualizareListaMedicamente();
            }
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
                lista = this.medP.FiltrareMedicamente(filtruSelectat, textFiltru);
            }
            else
                lista = this.medP.ListaMedicamente();

            if (lista != null)
            {
                List<DataGridViewRow> randuri = new List<DataGridViewRow>();
                foreach (Medicament medicament in lista)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = medicament.AccesCodMedicament().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = medicament.AccesDenumire() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = medicament.AccesDisponibilitate() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = medicament.AccesPret().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = medicament.AccesValabilitate() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = medicament.AccesProducator() });
                    randuri.Add(rand);
                }
                this.medV.ActualizareListaMedicamente(randuri);
            }
            else
                MessageBox.Show("Lista medicamentelor este vida!");
        }


        public void VizualizareListaMedicamenteCautateDenumire()
        {

            List<Medicament> lista = new List<Medicament>();
            string txtCautare = this.medV.AccesCautareDupaDenumire();

            if (txtCautare.Equals(""))
            {
                MessageBox.Show("Nu ati introdus denumirea medicamentului!");

            }
            else
                lista = this.medP.CautareMedicamenteDenumire(txtCautare);

            if (lista != null)
            {
                List<DataGridViewRow> randuri = new List<DataGridViewRow>();
                foreach (Medicament medicament in lista)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = medicament.AccesCodMedicament().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = medicament.AccesDenumire() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = medicament.AccesDisponibilitate() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = medicament.AccesPret().ToString() });
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
