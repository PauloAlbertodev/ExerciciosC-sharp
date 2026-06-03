namespace Ex29;
/*Implemente um programa 
que peça ao usuário um número
 N e imprima as potências de 2 de 0 até N.*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero:");
        int N = Convert.ToInt32(Console.ReadLine());

        for ( int i =0; i <= N; i++)
        {
            double potencia = Math.Pow(2,i);
            Console.WriteLine($"2^ {i} = {potencia}");
        }
    }
}
