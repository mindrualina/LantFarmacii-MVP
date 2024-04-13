
using LantFarmacii.Model;
using LantFarmacii.Model.Repository;
using LantFarmacii.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LantFarmacii.Presenter
{
    public class AdministratorP
    {
        private IAdministrator admV;
        private UtilizatorRepository utP;
        public AdministratorP(IAdministrator admV)
        {
            this.admV = admV;
            this.utP = new UtilizatorRepository();
        }
        public void AdaugareUtilizator()
        {
            bool dateCorecte = true;
            int rolSelectat = this.admV.AccesRolSelectat();
            if (rolSelectat < 0 || admV.AccesNume().Equals("") || admV.AccesLegitimatie().Equals("") || admV.AccesUser().Equals("")
                || admV.AccesParola().Equals(""))
            {
                dateCorecte = false;
                MessageBox.Show("Nu ati introdus toate datele necesare!");
            }
            else
            {
                string rol;
                uint nrLeg;

                if (rolSelectat == 1)
                    rol = "Angajat";
                else if (rolSelectat == 2)
                    rol = "Manager";
                else if (rolSelectat == 3)
                    rol = "Administrator";
                else rol = "";
                string leg = this.admV.AccesLegitimatie();

                if (rol == "")
                {
                    dateCorecte = false;
                    MessageBox.Show("Nu ati introdus toate datele necesare!");
                }

                bool conversie = uint.TryParse(leg, out nrLeg);
                if (conversie)
                {
                    nrLeg = Convert.ToUInt32(leg);
                    if (nrLeg == 0)
                    {
                        dateCorecte = false;
                        MessageBox.Show("ID-ul nu poate fi 0!");
                    }
                }

                if ((!Regex.IsMatch(leg, @"^\d+$")) && leg != "")
                {
                    MessageBox.Show("ID-ul trebuie sa fie compus din cifre!!!");
                    dateCorecte = false;
                }


                if (this.utP.CautareUtilizator(nrLeg) != null)
                {
                    MessageBox.Show("Exista alt utilizator cu acest ID!");
                    dateCorecte = false;
                }
                else
                {
                    string nume = this.admV.AccesNume();
                    string parola = this.admV.AccesParola();
                    string user = this.admV.AccesUser();
                    if (dateCorecte)
                    {
                        Utilizator ut = new Utilizator(nume, nrLeg, user, parola, rol);
                        bool succes = this.utP.AdaugareUtilizator(ut);
                        if (!succes)
                            MessageBox.Show("Eroare la adaugare!");
                        else
                            this.VizualizareLista();
                    }
                }
            }
        }
        public void VizualizareLista()
        {
            List<Utilizator> lista = this.utP.ListaUtilizatori();

            if (lista != null)
            {
                List<DataGridViewRow> randuri = new List<DataGridViewRow>();
                foreach (Utilizator ut in lista)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesLegitimatie().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesNume() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesCont() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesParola() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesRol() });
                    randuri.Add(rand);
                }
                this.admV.ActualizareListaUtilizatori(randuri);
            }
            else
                MessageBox.Show("Lista utilizatorilor este vida!");
        }
        public void ActualizareaUtilizator()
        {
            int nrLeg = this.admV.AccesLegitimatieSelectata();
            if (nrLeg == -1)
                MessageBox.Show("Nu s-a selectat niciun utilizator!");
            else
            {
                bool dateCorecte = true;
                int rolSelectat = this.admV.AccesRolSelectat();
                string rol;
                string leg;
                uint nrLegNou;

                if (rolSelectat == 1)
                    rol = "Angajat";
                else if (rolSelectat == 2)
                    rol = "Manager";
                else if (rolSelectat == 3)
                    rol = "Administrator";
                else rol = "";
                leg = this.admV.AccesLegitimatie();

                bool conversie = uint.TryParse(leg, out nrLegNou);
                if (conversie)
                {
                    nrLegNou = Convert.ToUInt32(leg);
                    if (nrLegNou == 0)
                    {
                        dateCorecte = false;
                        MessageBox.Show("ID-ul nu poate fi 0!");
                    }
                }

                if ((!Regex.IsMatch(leg, @"^\d+$")) && leg != "")
                {
                    MessageBox.Show("ID-ul trebuie sa fie compus din cifre!!!");
                    dateCorecte = false;
                }

                if (this.utP.CautareUtilizator(nrLegNou) != null)
                {
                    MessageBox.Show("Exista alt utilizator cu acest ID!");
                    dateCorecte = false;
                }
                else
                {
                    string nume = this.admV.AccesNume();
                    string parola = this.admV.AccesParola();
                    string user = this.admV.AccesUser();
                    if (dateCorecte)
                    {
                        Utilizator ut = new Utilizator(nume, nrLegNou, user, parola, rol);
                        bool succes = this.utP.ActualizareUtilizator((uint)nrLeg, ut);
                        if (!succes)
                            MessageBox.Show("Eroare la actualizare!");
                        else
                            this.VizualizareLista();
                    }
                }

            }
        }
        public void StergereUtilizator()
        {
            int nrLeg = this.admV.AccesLegitimatieSelectata();
            if (nrLeg == -1)
                MessageBox.Show("Nu s-a selectat niciun utilizator!");
            else
            {
                bool succes = this.utP.StergereUtilizator((uint)nrLeg);
                if (!succes)
                    MessageBox.Show("Nu s-a efectuat stergerea!");
                else
                    this.VizualizareLista();
            }
        }
    }
}
