using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class ReciboSueldo: Iimprimible
    {
        private int legajo;
        private int total;

        public ReciboSueldo(int legajo, int total)
        {
            this.legajo = legajo;
            this.total = total;
        }

        public virtual string Imprimir() { return $" LEGAJO: {legajo} \n TOTAL: {total}"; }

        public int getLegajo() { return  legajo; }
        public int getTotal() { return total; }
    }
}
