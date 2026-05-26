namespace Ex17;
   /*Implemente um programa que aplique
 um desconto num produto com base no preço, 10% se o preço for
maior ou igual que 100€ e 15% se for maior ou igual que 200€.
O programa deverá informar qual o preço final ao usuário*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um preço final:");
        double valor = Convert.ToInt32(Console.ReadLine());

        double desconto; 

        if (valor >= 200)
        {
            desconto = valor * 0.15;
        }
        else if (valor >= 100)
        {
            desconto = valor * 0.10;
        }
        else
        {
            desconto = 0;
        }
        Console.WriteLine($"Desconto: {desconto}.");
        Console.WriteLine($"Preço com desconto: {valor - desconto}.");
    }
}
