namespace Ex03;
                    /*Escreva um programa que leia uma palavra e mostre quantos caracteres ela possui,
                    ignorando espaços no início e fim (texto.Length).*/

class Program
{     
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma palavra");
        string palavra = Console.ReadLine();

        string ajustado = palavra.Trim();
        int tamanho = ajustado.Length;

        Console.WriteLine($"A palavra {ajustado}, possui {tamanho} caracteres.");
        
        

    }
}
