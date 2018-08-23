using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_de_tres_digitos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, resultado;
            Console.WriteLine("vamos a sumar tres digitos ");
            Console.Write("digite el primer numero ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("ahora el segundo ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("ahora el tercero ");
            num3 = int.Parse(Console.ReadLine());
            resultado = num1 + num2 + num3;
            Console.Write("el resultado es: "+ resultado);
            Console.ReadKey();
        }
    }
}
