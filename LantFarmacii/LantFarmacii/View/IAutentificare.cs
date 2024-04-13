using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LantFarmacii.View
{
    public interface IAutentificare
    {
        string AccesUser();
        string AccesParola();
        void ActualizareUser();
        void ActualizareParola();

        void ActualizareVizualizare();
    }
}
