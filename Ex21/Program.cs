using System.Reflection;

namespace Ex21;
/*Implemente 
um programa que peça ao usuário um 
número N e calcule a soma de todos os 
números pares
de 1 até N.*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int soma = 0; 

        for(int i = 2; i <= N; i += 2)
        {
            soma +=i;
        }
        Console.WriteLine($"soma = {soma}");
    }
}
