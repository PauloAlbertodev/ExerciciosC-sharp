using System.Globalization;

namespace Ex18;
/*Implemente um programa que peça
 um número inteiro e informe se é par ou ímpar.
Utilize o operador ternário.*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número:");
        int num  = Convert.ToInt32(Console.ReadLine());

        string res = (num % 2 ==0) ? "Par" : "Impar";
        Console.WriteLine(res);
    }


}
