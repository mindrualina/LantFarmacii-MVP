using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LantFarmacii.Model.Repository
{
    internal class FarmacieRepository
    {
        public FarmacieRepository()
        {
        }



        public bool AdaugaFarmacie(Farmacie farmacie)
        {
            try
            {
                XElement xElement = XElement.Load(@"farmacii.xml");
                xElement.Add(new XElement("farmacie",
                    new XElement("nume", farmacie.AccesNume().ToString()),
                    new XElement("adresa", farmacie.AccesAdresa()),
                    new XElement("telefon", farmacie.AccesTelefon()),
                    new XElement("cod_farmacie", farmacie.AccesCodFarmacie())
                    ));
                xElement.Save(@"farmacii.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adaugare farmacie! " + ex.ToString());
                return false;
            }
        }

        public List<Farmacie> ListaFarmacii()
        {

            try
            {
                List<Farmacie> listaFarmacii = new List<Farmacie>();
                XDocument xDoc = XDocument.Load(@"farmacii.xml");
                List<XElement> listaXML = xDoc.Root.Elements("farmacie").ToList();
                foreach (XElement xElem in listaXML)
                {
                    string nume = xElem.Element("nume").Value;
                    string adresa = xElem.Element("adresa").Value;
                    string telefon = xElem.Element("telefon").Value;
                    int cod_farmacie = int.Parse(xElem.Element("cod_farmacie").Value);
                    Farmacie f = new Farmacie(nume, adresa, telefon, cod_farmacie);
                    listaFarmacii.Add(f);
                }
                return listaFarmacii;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citire farmacii! " + ex.ToString());
                return null;
            }
        }


        public bool ActualizareFarmacie(int cod_farmacie, Farmacie farmacie)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"farmacii.xml");
                var element = xDoc.Root.Elements("farmacie").Where(e => e.Element("cod_farmacie").Value == cod_farmacie.ToString()).Single();
                element.Element("cod_farmacie").Value = farmacie.AccesCodFarmacie().ToString();
                if (farmacie.AccesNume() != "") element.Element("nume").Value = farmacie.AccesNume();
                if (farmacie.AccesAdresa() != "") element.Element("adresa").Value = farmacie.AccesAdresa();
                if (farmacie.AccesTelefon().ToString() != "0") element.Element("telefon").Value = farmacie.AccesTelefon().ToString();
                if (farmacie.AccesCodFarmacie().ToString() != "0") element.Element("cod_farmacie").Value = farmacie.AccesCodFarmacie().ToString();
                xDoc.Save(@"farmacii.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la actualizare farmacie! " + ex.ToString());
                return false;
            }
        }


        public bool StergereFarmacie(int cod_farmacie)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"farmacii.xml");
                xDoc.Root.Elements("farmacie").Where(e => e.Element("cod_farmacie").Value == cod_farmacie.ToString()).Remove();
                xDoc.Save(@"farmacii.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la stergere farmacie! " + ex.ToString());
                return false;
            }

        }
    }
}
