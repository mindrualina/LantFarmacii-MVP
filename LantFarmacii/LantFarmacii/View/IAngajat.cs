using LantFarmacii.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LantFarmacii.View
{
    public interface IAngajat
    {
        string AccesDenumire();

        string AccesCodMedicament();

        string AccesPret();

        int AccesCodMedicamentSelectat();

        int AccesDisponibilitate();

        string AccesProducator();

        string AccesValabilitate();

        void ActualizareListaMedicamente(List<DataGridViewRow> lista);

        


        int AccesareFiltruSelectat();

        string AccesFiltrare();
        string AccesCautareDupaDenumire();
    }
}
