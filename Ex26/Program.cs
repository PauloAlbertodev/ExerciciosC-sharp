namespace Ex26;
/*Implemente um programa que peça 
ao usuário a quantidade de termos e imprima a sequência de
Fibonacci até essa quantidade.*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de termos:");
        int termos = Convert.ToInt32(Console.ReadLine());

        int a = 0, b = 1;

        for(int i = 1; i <= termos; i++)
        {
           Console.Write($"{a}"); 
           int temp = a+b;
           a = b;
           b = temp;
        }

           Console.WriteLine();
    }       
}

