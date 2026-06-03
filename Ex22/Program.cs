namespace Ex22;
/*Implemente um programa
 que imprima uma contagem
  regressiva de 10 até 1 e, no 
  final, escreva "Fogo!".*/
class Program
{
    static void Main(string[] args)
    {
        int cont = 10;

        while (cont >0)
        {
            Console.WriteLine(cont);
            cont--;
        }
         Console.WriteLine("Fogo! ");
    }
}
