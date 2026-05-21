namespace Ex11;
    /*Implemente um programa que classifique
    uma temperatura digitada pelo usuário.
    Frio se for inferior a 10, agradável
    se for inferior a 25 e quente se for superior a 25.*/
  class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a temperatura:");
        int temp = Convert.ToInt32(Console.ReadLine());

        if (temp < 10)
        {
            Console.WriteLine("Frio");
        }
        else if (temp < 25)
        {
            Console.WriteLine("Agradavel");
        }
        else 
        {
            Console.WriteLine("Quente");
        }
         

    }
}
