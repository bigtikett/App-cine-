using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    using GestiónCine.Listas;
    using System.Collections.Generic;

    public static class EntradasVendidasManager
    {
        private static List<EntradasVendidas> entradasVendidas = new List<EntradasVendidas>();

        public static List<EntradasVendidas> ObtenerEntradasVendidas()
        {
            return entradasVendidas;
        }

        public static void AgregarEntradasVendidas(EntradasVendidas entrada)
        {
            entradasVendidas.Add(entrada);
        }
    }
}
