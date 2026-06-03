namespace Ex27;
/*Implemente um programa 
que imprima todos os números de 1 a 50 
que são divisíveis por 3 e por 5.*/
class Program
{
    static void Main(string[] args)
    {
      for(int i = 1; i <=50; i++)
        {
            if (i %3 == 0 && i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
