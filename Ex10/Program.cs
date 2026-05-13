namespace Ex10;
      //Escreva um programa que calcule o montante final de um investimento com juros simples:
      //formula : M = C + (C * i * t)
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Capital inicial: ");
        double C = double.Parse(Console.ReadLine());

        Console.WriteLine("taxa de juro (em %): ");
        double i = double.Parse(Console.ReadLine()) /100;
         
        Console.WriteLine("Tempo (em meses): ");
        double t = double.Parse(Console.ReadLine());

        double M = C + (C * i * t);
         
        Console.WriteLine($"Montante Final: {M:F2}");
        
 
    }
}
