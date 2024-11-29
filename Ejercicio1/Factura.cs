using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Factura : DocumentoContable
    {
        //padre * 1.22
        public Factura(DateTime fecha, int importe, int numero, int sigla) : base(fecha, importe, numero, sigla) { }
        public override int Total() { return base.Total() * (122 / 100); }
        public override string Imprimir() { return $" FECHA: {this.getFecha()} \n IMPORTE: {this.getImporte()} \n NUMERO: {this.getNumero()} \n SIGLA: {this.getSigla()}"; }
        
    }
}
