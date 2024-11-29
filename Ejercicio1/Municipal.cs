using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Municipal:Impuesto
    {
        private int partida;
        public Municipal(int importe, int partida):base(importe)
        {
            this.partida = partida;
        }

        public override string Imprimir() { return $" IMPORTE: {this.getImporte()} \n PARTIDA: {this.partida}"; }

        public int getPartida() {  return partida; }
    }
}
