using System.Globalization;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PraticandoConceitos.Conceitos;

public class ProgramaSeis
{
    static void Main()
    {

        while (true)
        {
            Console.WriteLine("Insira a data em dia do mês, mês, ano, hora, minutos e segundos.");
            string data1 = Console.ReadLine();

            string formato1 = @"^Dia \d{1,2}, do Mês \d{1,2}, do Ano de \d{4}\. \d{1,2} horas, \d{1,2} minutos e \d{1,2} segundos$";


            if (Regex.IsMatch(data1, formato1))
            {
                Console.WriteLine("Formato Válido!");
                break;
            }

            else
                Console.WriteLine("Formato inválido!");
        }

        while (true)
        {
            Console.WriteLine("Agora insira a data no formato dd/mm/yyyy");
            string data2 = Console.ReadLine(); 
            


            if (DateTime.TryParseExact(data2, "dd/MM/yyyy", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime dataA))
            {
                Console.WriteLine("Formato Válido!");
                break;
            }
            else
                Console.WriteLine("Formato inválido!");
        }

        while (true)
        {
            Console.WriteLine("Agora insira a data no formato de HH horas");
            string data3 = Console.ReadLine();

            data3 = data3.Replace(" horas", "");



            if (DateTime.TryParseExact(data3, "HH", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime dataA))
            {
                Console.WriteLine("Formato Válido!");
                break;
            }
            else
                Console.WriteLine("Formato inválido!");
        }

        while (true)
        {
            Console.WriteLine("Agora insira a data no formato de HH horas");
            string data4 = Console.ReadLine();

            string[] meses =
            {
                "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
            };



            if (Array.Exists(meses, mes => mes.Equals(data4, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Formato Válido!");
                break;
            }
            else
                Console.WriteLine("Formato inválido!");
        }
        Console.WriteLine("Parábens!");
    }
}
