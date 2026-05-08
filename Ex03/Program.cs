namespace Ex03;
                    /*Escreva um programa que leia uma palavra e mostre quantos caracteres ela possui,
                    ignorando espaços no início e fim (texto.Length).*/

class Program
{     
    static void Main(string[] args)
    {
        Console.WriteLine("digite uma palavra");
        string texto = Console.ReadLine();
        texto = texto.Trim();
        texto.Length;

    }
}
