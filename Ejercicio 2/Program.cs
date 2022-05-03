using System;
using logica;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CajaAhorro caja = new CajaAhorro();
            caja.CambioFinalizado += CambioRealizadoHandler;
            caja.Retiro(500);
            
        }
        static void CambioRealizadoHandler(object sender, CambioEventArgs e)
        {
            Console.WriteLine("El cliente es" + e.Nombre, "realizò un" + e.Accion, "y su saldo final es" + e.saldoFinal);
        }
}
}

