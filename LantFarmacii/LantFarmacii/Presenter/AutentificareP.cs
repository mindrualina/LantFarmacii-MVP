
using LantFarmacii.View;
using LantFarmacii.Model;
using LantFarmacii.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LantFarmacii.Presenter
{
    public class AutentificareP
    {
        private IAutentificare aV;
        private UtilizatorRepository utP;
        public AutentificareP(IAutentificare aV)
        {
            this.aV = aV;
            this.utP = new UtilizatorRepository();
        }
        public void Logare()
        {
            string user = this.aV.AccesUser();
            string parola = this.aV.AccesParola();
            Utilizator ut = this.utP.CautareUtilizator(user, parola);
            if (ut == null)
            {
                MessageBox.Show("Nu exista niciun cont cu datele specificate!");
                this.aV.ActualizareUser();
                this.aV.ActualizareParola();
                AutentificareV autentificareV = new AutentificareV();
                autentificareV.Show();
            }
            else
            {
                string rol = ut.AccesRol();
                if (rol.ToUpper() == "ADMINISTRATOR")
                {
                    AutentificareV autentificareV = new AutentificareV();
                    autentificareV.Hide();
                    AdministratorV admV = new AdministratorV();
                    admV.Show();
                }
                else if (rol.ToUpper() == "MANAGER")
                {
                    AutentificareV autentificareV = new AutentificareV();
                    autentificareV.Hide();
                    Manager mngV = new Manager();
                    mngV.Show();

                }    

                else
                {
                    AutentificareV autentificareV = new AutentificareV();
                    autentificareV.Hide();
                    AngajatV angajatV = new AngajatV();
                    angajatV.Show();
                }
            }
        }
    }
}
