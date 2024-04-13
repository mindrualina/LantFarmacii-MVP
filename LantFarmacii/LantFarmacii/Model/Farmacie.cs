using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LantFarmacii.Model
{
    public class Farmacie
    {
        // Proprietățile clasei
        private string nume;
        private string adresa;
        private string telefon;
        private int cod_farmacie;

        // Constructor implicit
        public Farmacie()
        {
        }

        // Constructor cu parametri
        public Farmacie(string nume, string adresa, string telefon, int cod_farmacie)
        {
            this.nume = nume;
            this.adresa = adresa;
            this.telefon = telefon;
            this.cod_farmacie = cod_farmacie;
        }

        // Metode de acces (getters) și modificare (setters)
        public string AccesNume()
        {
            return nume;
        }

        public void ActualizareNume(string nume)
        {
            this.nume = nume;
        }

        public string AccesAdresa()
        {
            return adresa;
        }

        public void ActualizareAdresa(string adresa)
        {
            this.adresa = adresa;
        }

        public string AccesTelefon()
        {
            return telefon;
        }

        public void ActualizareTelefon(string telefon)
        {
            this.telefon = telefon;
        }

        public int AccesCodFarmacie()
        {
            return cod_farmacie;
        }

        public void ActualizareCodFarmacie(int cod_farmacie)
        {
            this.cod_farmacie = cod_farmacie;
        }

        // Metoda ToString() actualizată
        public override string ToString()
        {
            return this.cod_farmacie.ToString() + ";" + this.nume + ";" + this.adresa + ";" + this.telefon;
        }

    }
}
