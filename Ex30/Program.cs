namespace Ex30;
/*Implemente um programa que peça um número 
N e imprima o quadrado de 
todos os números de 1 até
N*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero:");
        int N = Convert.ToInt32(Console.ReadLine());

        for ( int i =1; i <= N; i++)
        {
            
            Console.WriteLine($"O quadrado de {i} é {i*i}");
        }
    }
}
