/*namespace PraticandoConceitos.Conceitos;

public class ProgramaQuatro
{
    static void Main()
        {
            Console.WriteLine("Insira quaisquer caracteres");

            string palavra = Console.ReadLine();
            string palavraE = palavra.Replace(" ", "");
            int count = palavra.Length;

            Console.WriteLine($"A palavra inserida tem {count} caracteres.");
        }


    
}

//ou 
/*
public class ProgramaQuatro
{
static void Main()
    {
        Console.WriteLine("Insira quaisquer caracteres");

        string palavra = Console.ReadLine();
        int count = 0;

        foreach (char ch in palavra)
        {
            if (ch != ' ')
            {
                count++;
            }
        }

        Console.WriteLine($"A palavra inserida tem {count} caracteres.");
    }
}
*/
