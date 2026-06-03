namespace Ex28;
/*Implemente um programa peça ao 
usuário um número inteiro e calcule seu fatorial*/
class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Digite um numero:");
      int num = Convert.ToInt32(Console.ReadLine());

      int fatorial = 1;
      int contadorFatorial = num;
       
      while(contadorFatorial > 1)
        {
            fatorial *= contadorFatorial;
            contadorFatorial--;
        } 
        Console.WriteLine($"{num}! = {fatorial}");
    
      

    }
}
