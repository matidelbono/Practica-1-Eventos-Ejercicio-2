using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class CambioEventArgs:EventArgs
    {
        public decimal saldoFinal { get; set; }
        public string Nombre { get; set; }
        public string Accion { get; set; }
    }
}

