using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LantFarmacii.Model
{
    internal class Medicament
    {
        private int cod_medicament;

        private string denumire;

        private string disponibilitate;

        private uint pret;

        private string producator;

        private string valabilitate;

        public Medicament()
        {
            this.cod_medicament = 0;
            this.denumire = "";
            this.disponibilitate = "";
            this.pret = 0;
            this.producator = "";
            this.valabilitate = "";
        }

        public Medicament(int cod_medicament, string denumire, string disponibilitate, uint pret, string valabilitate, string producator)
        {
            this.cod_medicament = cod_medicament;
            this.denumire = denumire;
            this.disponibilitate = disponibilitate;
            this.pret = pret;
            this.producator = producator;
            this.valabilitate = valabilitate;

        }


        public Medicament(Medicament m)
        {
            this.cod_medicament = m.cod_medicament;
            this.denumire = m.denumire;
            this.disponibilitate = m.disponibilitate;
            this.pret = m.pret;
            this.producator = m.producator;
            this.valabilitate = m.valabilitate;
        }


        public int AccesCodMedicament()
        {
            return this.cod_medicament;
        }


        public string AccesDenumire()
        {
            return this.denumire;
        }


        public string AccesDisponibilitate()
        {
            return this.disponibilitate;
        }


        public uint AccesPret()
        {
            return this.pret;
        }


        public string AccesProducator()
        {
            return this.producator;
        }

        public string AccesValabilitate()
        {
            return this.valabilitate;
        }

        public void ActualizareCodMedicament(int cod_medicament)
        {
            this.cod_medicament = cod_medicament;
        }

        public void ActualizareDenumire(string denumire)
        {
            this.denumire = denumire;
        }

        public void ActualizareDisponibilitate(string disponibilitate)
        {
            this.disponibilitate = disponibilitate; ;
        }

        public void ActualizarePret(uint pret)
        {
            this.pret = pret;
        }

        public void ActualizareProducator(string producator)
        {
            this.producator = producator;
        }

        public void ActualizareValabilitate(string valabilitate)
        {
            this.valabilitate = valabilitate;
        }

        public override string ToString()
        {
            return this.cod_medicament.ToString() + ";" + this.denumire + ";" + this.disponibilitate + ";" + this.pret.ToString() + ";" + this.producator + this.valabilitate;
        }
    }
}
