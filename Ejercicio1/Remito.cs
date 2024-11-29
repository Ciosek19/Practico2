using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Remito:Iimprimible
    {
        private int cantBultos;
        private DateTime fecha;
        private int numero;

        public Remito(int cantBultos, DateTime fecha, int numero)
        {
            this.cantBultos = cantBultos;
            this.fecha = fecha;
            this.numero = numero;
        }

        public virtual string Imprimir() { return $" CANTIDAD BULTOS: {cantBultos} \n FECHA: {fecha} \n NUMERO: {numero}"; }

        public int getCantBultos() {  return cantBultos; }
        public DateTime getFecha() { return fecha; }
        public int getNumero() { return numero; }
    }
}
