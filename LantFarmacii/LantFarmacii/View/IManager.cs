using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LantFarmacii.View
{
    public interface IManager
    {

  

        int AccesareFiltruSelectat();

        string AccesFiltrare();


        void ActualizareListaMedicamente(List<DataGridViewRow> lista);

    }
}
