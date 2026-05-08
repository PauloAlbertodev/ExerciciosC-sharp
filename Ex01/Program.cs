using System.Reflection;
using System.Security.AccessControl;

namespace Ex01;
  /*Escreva um programa que leia uma 
  temperatura em celsius e exiba-a 
  convertida para Fahrenheit com duas casas decimais.
  Formula : (celsius *9/5) + 32 */


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("digite uma temperatura em celsius:?");
        double temp = double.Parse(Console.ReadLine());

        double fahr = (temp *9/5)+32;
        Console.WriteLine($"a temperatura  é igual a : {fahr:f2}f");
        

       

        
        
        

    }
}
