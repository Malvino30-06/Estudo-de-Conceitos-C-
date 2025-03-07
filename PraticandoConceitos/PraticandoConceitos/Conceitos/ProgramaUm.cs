/*using System.Text.RegularExpressions;

namespace PraticandoConceitos.Conceitos;

public class ProgramaUm
{

    static string Boa()
    {
        return "Bem-Vindo!";
    }
    static void Main()
    {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        string boas = Boa();

        if (string.IsNullOrEmpty(nome)) //regex representa expressões regulares, ismatch verifica se o texto corresponde
            Console.WriteLine("Erro: O nome não pode estar vazio.");

        else if (Regex.IsMatch(nome, @"\W")) 
            Console.WriteLine("Erro: O nome não pode conter simbolos.");

        else if (Regex.IsMatch(nome, @"\d"))
            Console.WriteLine("Erro: O nome não pode conter números.");

        else
            Console.WriteLine(nome + ", " + boas);
        
    }
}
*/