using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotaCredito notacredito = new NotaCredito(DateTime.Now, 50, 20, 123);
            Factura factura = new Factura(DateTime.Now, 154, 30, 124);
            ReciboSueldo reciboSueldo = new ReciboSueldo(10, 2000);
            FacturaLuz facturaLuz = new FacturaLuz(1000, 12345);
            Municipal municipal = new Municipal(20000, 321);
            Remito remito = new Remito(2, DateTime.Now, 50);

            Console.WriteLine($"Nota credito: \n{notacredito.Imprimir()} \n");
            Console.WriteLine($"Factura: \n{factura.Imprimir()} \n");
            Console.WriteLine($"Recibo Sueldo: \n{factura.Imprimir()}\n");
            Console.WriteLine($"Factura Luz: \n{facturaLuz.Imprimir()}\n");
            Console.WriteLine($"Municipal: \n{municipal.Imprimir()}\n");
            Console.WriteLine($"Remito: \n{remito.Imprimir()}");
            Console.ReadKey();
        }
    }
}
