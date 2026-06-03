namespace Ex25;
/*IImplemente um programa 
que peça ao usuário um número N e imprima os números de 1 até N, mas
alternando o sinal: o
primeiro positivo, o segundo negativo, 
o terceiro positivo, e assim por diante*/
class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Digite um numero:");
      int N = Convert.ToInt32(Console.ReadLine());
      
      for (int i =1; i <= N; i++)
        {
           if (i % 2 == 0)
            {
                Console.WriteLine(-i);
            }
            else
            {
                Console.WriteLine(i);
            } 
        }
    }
}
