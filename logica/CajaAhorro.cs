using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class CajaAhorro
    {
        public EventHandler<CambioEventArgs> CambioFinalizado;
        public string Nombre { get; set; }
        public decimal SaldoActual { get; set; }
        public decimal Deposito(decimal CantidadADepositar)
        {
            decimal SaldoFinal= SaldoActual + CantidadADepositar;
            if (this.CambioFinalizado != null)
                this.CambioFinalizado(this, new CambioEventArgs() { saldoFinal = SaldoFinal });
            return SaldoFinal;
        }
        public decimal Retiro (decimal CantidadARetirar)
        {
            if (CantidadARetirar<=SaldoActual)
            {
                decimal SaldoFinal= SaldoActual - CantidadARetirar;
                if(this.CambioFinalizado != null)
                this.CambioFinalizado(this, new CambioEventArgs() { saldoFinal = SaldoFinal });
                return SaldoFinal;
                
            }
            return 0;
        
    }
}
}
