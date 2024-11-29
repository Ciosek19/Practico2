using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class DocumentoContable : Iimprimible
    {
        private DateTime fecha;
        private int importe;
        private int numero;
        private int sigla;
        //importe

        public DocumentoContable (DateTime fecha,int importe, int numero, int sigla) 
        {
            this.fecha = fecha;
            this.importe = importe;
            this.numero = numero;
            this.sigla = sigla;
        }

        public virtual string Imprimir() { return $" FECHA: {fecha} \n IMPORTE: {importe} \n NUMERO: {numero} \n SIGLA: {sigla}"; }
        public virtual int Total() { return importe; }

        public DateTime getFecha() {  return fecha; }
        public int getImporte() {  return importe; }
        public int getNumero() {  return numero; }
        public int getSigla() {  return sigla; }
    }
}
