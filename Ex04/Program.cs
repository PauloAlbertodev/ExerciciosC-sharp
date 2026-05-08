namespace Ex04;
                  /*Escreva um programa que leia o raio de um círculo e calcule a área utilizando Math.Pow() e
                 uma constante para π. */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o raio do circulo");
        double raio = double.Parse(Console.ReadLine());

        double area = Math.PI * Math.Pow(raio,2);
        Console.WriteLine($"A area do circulo é:"+area);

    }
}
