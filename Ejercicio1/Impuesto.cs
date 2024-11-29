using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Impuesto:Iimprimible
    {
        private int importe;

        public Impuesto(int importe)
        {
            this.importe = importe;
        }

        public virtual string Imprimir() { return $" IMPORTE: {importe}"; }
        public int getImporte() {  return importe; }
    }
}
