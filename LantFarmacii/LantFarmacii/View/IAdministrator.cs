using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LantFarmacii.View
{
    public interface IAdministrator
    {
        string AccesNume();
        string AccesParola();

        string AccesLegitimatie();
        string AccesUser();
        int AccesRolSelectat();

        int AccesLegitimatieSelectata();

        void ActualizareListaUtilizatori(List<DataGridViewRow> lista);

    }
}
