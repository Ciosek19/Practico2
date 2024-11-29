using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class FacturaLuz:Impuesto
    {
        private int codigoPago;

        public FacturaLuz(int importe, int codigoPago):base(importe)
        {
            this.codigoPago = codigoPago;
        }

        public override string Imprimir() { return $" IMPORTE: {this.getImporte()} \n CODIGO PAGO: {this.codigoPago}"; }
        public int getCodigoPago() {  return codigoPago; }
    }
}
