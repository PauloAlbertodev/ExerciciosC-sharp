namespace Ex06; 
//Escreva um programa que leia as coordenadas de dois pontos (x1,y1,x2,y2)
//e calcule a distancia entre eles.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("x1:");
        double x1 = double.Parse(Console.ReadLine());

        Console.WriteLine("y1:");
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("x2:");
        double x2 = double.Parse(Console.ReadLine());

        Console.WriteLine("y2:");
        double y2 = double.Parse(Console.ReadLine());

        //raiz de [ (x2-x1)^2  + (y2-y1)^2 ]

        double distancia = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
        Console.WriteLine($"A distancia entre os dois pontos é: = {distancia:F2}");



    }
}
