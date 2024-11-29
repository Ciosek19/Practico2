using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio1
{
    internal class Impresora
    {
        public void Imprimir(DocumentoContable documento) { Console.WriteLine(documento.Imprimir()); }
        public void Imprimir(FacturaLuz factura) { Console.WriteLine(factura.Imprimir()); }
        public void Imprimir(Municipal municipal) { Console.WriteLine(municipal.Imprimir()); }
        public void Imprimir(ReciboSueldo recibo) { Console.WriteLine(recibo.Imprimir()); }
        public void Imprimir(Remito remito) { Console.WriteLine(remito.Imprimir()); }
    }
}
