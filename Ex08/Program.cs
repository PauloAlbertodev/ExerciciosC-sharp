namespace Ex08;
    //Escreva um programa que leia um numero decimal e mostre:
    // a raiz quadrada
    // o valor arredondado
    //e o valor elevado ao cubo
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero decimal:");
        double num = double.Parse(Console.ReadLine());

        Console.WriteLine($"Raiz Quadrada: {Math.Sqrt(num):F2}");
        Console.WriteLine($"Arredondado: {Math.Round(num)}");
        Console.WriteLine($"Cubo: {Math.Pow(num,3):F2}");
        

    
    }
}
