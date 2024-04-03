using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiónCine.Listas
{
    public class Peliculas
    {
        public string Titulo {  get; set; }
        public TipoGenero Genero { get; set; }
        public decimal Precio { get; set; }
        public int ID { get; set; }
        public enum TipoGenero
        {
            Comedia=0,
            Drama=1,
            Acción=2,
            CienciaFicción=3,
            Fantasía=4,
            Musical=5,
            Terror=6,
            Suspense=7,
            Romance=8,
            Policíaco=9,
            Infantil=10
        }
        public void RellenarPelicula()
        {
            Console.WriteLine("Introduce el titulo de la pelicula:");
            Titulo = Console.ReadLine();
            Console.WriteLine("Introduce el tipo de género");
            Console.WriteLine("\r\n            0 - Comedia,\r\n            1 - Drama,\r\n            2 - Acción,\r\n            3 - CienciaFicción,\r\n            4 - Fantasía,\r\n            5 - Musical,\r\n            6 - Terror,\r\n            7 - Suspense,\r\n            8 - Romance,\r\n            9 - Policíaco,\r\n            10 - Infantil");
            Genero=(TipoGenero)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine($"La película: {Titulo} es {Genero}");
            Console.WriteLine("Introduce el precio de la película:");
            Precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"La ID asignada es:{ID}");
            
        }
    }
}
