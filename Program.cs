using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_LeonardoToscano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prec;
            int tam, opc;

            Console.WriteLine("venta de jugos");

            Console.WriteLine();
            Console.WriteLine("1. Naranja");
            Console.WriteLine("2. Fresa");
            Console.WriteLine("3. Lucuma");
            Console.WriteLine("4. Papaya");
            Console.WriteLine("5. Surtido");
            Console.WriteLine("6. Piña");

            Console.WriteLine();
            Console.Write("digitar el # segun el jugo a pedir: ");
            opc = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("1. Large");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Small");

            Console.WriteLine();
            Console.Write("digitar el # segun el tamaño deseado: ");
            tam = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    if (tam == 1) prec = 15.50;
                    else if (tam == 2) prec = 12.00;
                    else prec = 10.50;
                    break;

                case 2:
                    if (tam == 1) prec = 17.00;
                    else if (tam == 2) prec = 13.70;
                    else prec = 11.50;
                    break;

                case 3:
                    if (tam == 1) prec = 14.20;
                    else if (tam == 2) prec = 11.50;
                    else prec = 9.70;
                    break;

                case 4:
                    if (tam == 1) prec = 10.00;
                    else if (tam == 2) prec = 8.50;
                    else prec = 6.50;
                    break;

                case 5:
                    if (tam == 1) prec = 20.00;
                    else if (tam == 2) prec = 17.00;
                    else prec = 15.00;
                    break;

                default:
                    if (tam == 1) prec = 11.50;
                    else if (tam == 2) prec = 9.40;
                    else prec = 7.20;
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("metodos de pago:");
            Console.WriteLine("1. Efectivo");
            Console.WriteLine("2. Targeta");

            Console.WriteLine();
            Console.Write("digite el numero de metodo de pago: ");
            int pago = int.Parse(Console.ReadLine());

            double totalpaga;

            if (pago == 1) totalpaga = 0.92 * prec;
            else totalpaga = 1.07 * prec;

            Console.WriteLine();
            Console.WriteLine("Ud. Pagará: " + totalpaga);

            Console.ReadKey();
        }
    }
}
