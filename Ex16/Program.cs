namespace Ex16;
/*Implemente um programa que mostre
 um menu de bebidas e peça ao utilizador que escolha uma opção.
Utilize a estrutura switch-case*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu");
        Console.WriteLine("[1] - Café");
        Console.WriteLine("[2] - Chá");
        Console.WriteLine("[3] - Bolo");
        Console.WriteLine("[4] - Água");
        int op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
          case 1: Console.WriteLine("Café"); break;
          case 2: Console.WriteLine("Chá");  break;
          case 3: Console.WriteLine("Bolo"); break;
          case 4: Console.WriteLine("Água"); break;
          default: Console.WriteLine("Opção inválida!");break;              
        }
    }
}
