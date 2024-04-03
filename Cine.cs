using GestiónCine.Listas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestiónCine;

namespace GestiónCine
{
    internal class Cine
    {
        public List<Peliculas> Peliculas {  get; private set; }
        public List<EntradasVendidas> EntradasVendidas { get; set; }
        public Cine() 
        {
            Peliculas = new List<Peliculas>();
            EntradasVendidas = new List<EntradasVendidas> { };
        }
        public void ComprarEntradas()
        {
            Console.WriteLine("Introduzca el ID de la película a comprar:");
            int idPelicula = Convert.ToInt32(Console.ReadLine());
            bool entradas = false;

            foreach (Peliculas p in Peliculas)
            {
                if (idPelicula == p.ID)
                {
                    Console.WriteLine($"Entrada para ver {p.Titulo}");

                    EntradasVendidas ev = new EntradasVendidas { Precio = p.Precio, Titulo = p.Titulo };

                    Console.WriteLine("¿Cuántas entradas desea?");
                    ev.Entradas = Convert.ToInt32(Console.ReadLine());

                    if (ev.Entradas > 0)
                    {
                        Console.WriteLine($"Elija {ev.Entradas} número de asiento:");
                        List<int> nAsientos = new List<int>();
                        for (int i = 0; i < ev.Entradas; i++)
                        {
                            Console.WriteLine($"Asiento Nº{i + 1}");
                            int nAsiento = Convert.ToInt32(Console.ReadLine());
                            nAsientos.Add(nAsiento);
                        }
                        ev.NºAsiento = nAsientos.Count;
                    }

                    decimal precioTotal = ev.Precio * 1.21m * ev.Entradas;
                    Console.WriteLine($"Nº de entradas: {ev.Entradas}, Asientos: {ev.NºAsiento}, Precio total: {precioTotal} Euros");
                    Console.WriteLine("Disfrute de la película!");

                    EntradasVendidas.Add(ev);

                    entradas = true;
                    ev.Ventas=true;
                    break; 
                }
            }

            if (!entradas)
            {
                Console.WriteLine("La ID no coincide con ninguna película de la cartelera.");
            }
        }

    }
}
