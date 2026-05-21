namespace Ex12;
   /*Implemente um programa
 que informe ao usuário se um ano
  digitado é bissexto ou não.
Obs: Um ano é bissexto se for divisível 
por 400 ou se for divisível por 4 e não por 100.*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um ano:");
        int ano = Convert.ToInt32(Console.ReadLine());
         
        if ((ano % 400 == 0) || ( ano % 4 == 0 && ano % 100 !=0))
        {
            Console.WriteLine("O ano é Bissexto!");  

        }
        else
        {
            Console.WriteLine("Não é bissexto!");
        }

    
    }
   

}
