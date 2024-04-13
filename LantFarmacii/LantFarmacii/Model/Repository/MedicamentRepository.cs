using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LantFarmacii.Model.Repository
{
    internal class MedicamentRepository
    {
        public bool AdaugareMedicament(Medicament medicament)
        {
            try
            {
                XElement xElement = XElement.Load(@"medicamente.xml");
                xElement.Add(new XElement("medicament",
                    new XElement("cod_medicament", medicament.AccesCodMedicament().ToString()),
                    new XElement("denumire", medicament.AccesDenumire()),
                    new XElement("disponibilitate", medicament.AccesDisponibilitate()),
                    new XElement("pret", medicament.AccesPret().ToString()),
                    new XElement("valabilitate", medicament.AccesValabilitate()),
                     new XElement("producator", medicament.AccesProducator())
                    ));
                xElement.Save(@"medicamente.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adaugare medicament! " + ex.ToString());
                return false;
            }
        }
        public bool StergereMedicament(int cod_medicament)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"medicamente.xml");
                xDoc.Root.Elements("medicament").Where(e => e.Element("cod_medicament").Value == cod_medicament.ToString()).Remove();
                xDoc.Save(@"medicamente.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la stergere medicament! " + ex.ToString());
                return false;
            }
        }
        public bool ActualizareMedicament(string cod_medicament, Medicament medicament)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"medicamente.xml");
                var element = xDoc.Root.Elements("medicament").Where(e => e.Element("cod_medicament").Value == cod_medicament.ToString()).Single();
                element.Element("cod_medicament").Value = medicament.AccesCodMedicament().ToString();
                if (medicament.AccesDenumire() != "") element.Element("denumire").Value = medicament.AccesDenumire();
                if (medicament.AccesDisponibilitate() != "") element.Element("disponibilitate").Value = medicament.AccesDisponibilitate();
                if (medicament.AccesPret().ToString() != "0") element.Element("pret").Value = medicament.AccesPret().ToString();
                if (medicament.AccesProducator() != "") element.Element("producator").Value = medicament.AccesProducator();
                if (medicament.AccesValabilitate() != "") element.Element("valabilitate").Value = medicament.AccesValabilitate();
                xDoc.Save(@"medicamente.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la actualizare medicament! " + ex.ToString());
                return false;
            }
        }
        public Medicament CautareMedicament(int cod_medicament)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"medicamente.xml");
                List<XElement> lista = xDoc.Root.Elements("medicament").ToList();
                foreach (XElement xElem in lista)
                {
                    XElement codElement = xElem.Element("cod_medicament");
                    string cod = codElement.Element("cod_medicament").Value;

                    int cm = (int)Convert.ToUInt32(xElem.Element("cod_medicament").Value);
                    if (cm == cod_medicament)
                    {
                        string denumire = xElem.Element("denumire").Value;
                        string disponibilitate = xElem.Element("disponibilitate").Value;
                        uint pret = Convert.ToUInt32(xElem.Element("pret").Value);
                        string valabilitate = xElem.Element("valabilitate").Value;
                        string producator = xElem.Element("producator").Value;

                        Medicament medicament = new Medicament(cod_medicament, denumire, disponibilitate,pret, valabilitate, producator);

                        return medicament;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la cautare autovehicul! " + ex.ToString());
                return null;
            }
        }
        public List<Medicament> ListaMedicamente()
        {
            try
            {
                List<Medicament> listaMedicamente = new List<Medicament>();
                XDocument xDoc = XDocument.Load(@"medicamente.xml");
                List<XElement> listaXML = xDoc.Root.Elements("medicament").ToList();
                foreach (XElement xElem in listaXML)
                {
                    
                    string denumire = xElem.Element("denumire").Value;
                    int cod_medicament = Convert.ToInt32(xElem.Element("cod_medicament").Value);
                    string disponibilitate = xElem.Element("disponibilitate").Value;
                    uint pret = Convert.ToUInt32(xElem.Element("pret").Value);
                    string valabilitate = xElem.Element("valabilitate").Value;
                    string producator = xElem.Element("producator").Value;
                    Medicament m = new Medicament(cod_medicament, denumire, disponibilitate, pret, valabilitate, producator);
                    listaMedicamente.Add(m);
                }
                return listaMedicamente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citire medicamente! " + ex.ToString());
                return null;
            }
        }

        public List<Medicament> FiltrareMedicamente(string filtruSelectat, string textFiltru)
        {
            try
            {
                List<Medicament> listaMedicamente = new List<Medicament>();
                XDocument xDoc = XDocument.Load(@"medicamente.xml");
                List<XElement> listaXML = xDoc.Root.Elements("medicament").ToList();
                foreach (XElement xElem in listaXML)
                {

                    string filtru = xElem.Element(filtruSelectat).Value;
                    if (filtru == textFiltru)
                    {
                        string denumire = xElem.Element("denumire").Value;
                        int cod_medicament = Convert.ToInt32(xElem.Element("cod_medicament").Value);
                        string disponibilitate = xElem.Element("disponibilitate").Value;
                        uint pret = Convert.ToUInt32(xElem.Element("pret").Value);
                        string valabilitate = xElem.Element("valabilitate").Value;
                        string producator = xElem.Element("producator").Value;
                        
                        Medicament m = new Medicament(cod_medicament, denumire, disponibilitate, pret, valabilitate, producator);
                        listaMedicamente.Add(m);
                    }
                }
                return listaMedicamente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la filtrare medicamente! " + ex.ToString());
                return null;
            }
        }


        public List<Medicament> CautareMedicamenteDenumire(string txtCautare)
        {
            try
            {
                List<Medicament> listaMedicamente = new List<Medicament>();
                XDocument xDoc = XDocument.Load(@"medicamente.xml");
                List<XElement> listaXML = xDoc.Root.Elements("medicament").ToList();
                foreach (XElement xElem in listaXML)
                {

                    string denum = xElem.Element("denumire").Value;
                    if (denum == txtCautare)
                    {
                        string denumire = xElem.Element("denumire").Value;
                        int cod_medicament = Convert.ToInt32(xElem.Element("cod_medicament").Value);
                        string disponibilitate = xElem.Element("disponibilitate").Value;
                        uint pret = Convert.ToUInt32(xElem.Element("pret").Value);
                        string producator = xElem.Element("producator").Value;
                        string valabilitate = xElem.Element("valabilitate").Value;
                        Medicament m = new Medicament(cod_medicament, denumire, disponibilitate, pret, valabilitate, producator);
                        listaMedicamente.Add(m);
                    }
                }
                return listaMedicamente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la filtrare medicamente! " + ex.ToString());
                return null;
            }
        }

       

    }
}
