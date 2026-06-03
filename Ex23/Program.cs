using System.Runtime.Serialization.Formatters;

namespace Ex23;
/*Implemente um programa que 
peça um número ao usuário e
imprima sua tabuada de 1 a 10.*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero:");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i<=10; i++)
        {
            Console.WriteLine($"{num}x{i}={num*i}");
        }
    }
}
