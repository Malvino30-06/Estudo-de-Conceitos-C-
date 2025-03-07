/*using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace PraticandoConceitos.Conceitos;

public class ProgramaTrês
{
    static void Main()
    {
        Console.WriteLine("Insira o número X");
        string valor1;
        double y;

        while (true)
        {
            valor1 = Console.ReadLine();


            if (Regex.IsMatch(valor1, @"\W") || Regex.IsMatch(valor1, @"\p{L}"))
            {
                Console.WriteLine("Insira um número válido");
                continue;
            }

            y = double.Parse(valor1);
            break;
        }

        Console.WriteLine("Insira o número Y");
        string valor2;
        double x;

        while (true)
        {
            valor2 = Console.ReadLine();


            if (Regex.IsMatch(valor2, @"\W") || Regex.IsMatch(valor2, @"\p{L}"))
            {
                Console.WriteLine("Insira um número válido");
                continue;
            }

            x = double.Parse(valor2);
            break;
        }

     
            Console.WriteLine("Resultado:");
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine((x + y) / 2);
    }


}
*/