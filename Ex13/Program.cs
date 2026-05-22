namespace Ex13;
  /*Implemente um programa que 
 classifique uma nota de 0 a 20 em reprovado se for menor que 10,
 suficiente se estiver entre 10 e 13, bom se estiver entre 13 e 16 e muito bom se 
 r acima de 16.
  O programa deve informar também se a nota está no intervalo correto.*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma nota:");
        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota < 0 || nota > 20)
        {
            Console.WriteLine("Nota fora do invervalo");
        }
        else if (nota < 10)
        {
            Console.WriteLine("Reprovado!");
        }
        else if (nota <= 13)
        {
            Console.WriteLine("Suficente");
        }
        else if (nota <= 16)
        {
            Console.WriteLine("Bom!");
        }


    }
}
