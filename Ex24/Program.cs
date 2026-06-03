namespace Ex24;
/*Implemente um programa que peça um número 
inteiro e conte quantos dígitos ele possui*/
class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Digite um numero:");
       int num = Convert.ToInt32(Console.ReadLine());

       int contador =0;

        while (num !=0)
        {
            num /=10;
            contador++;

        }
          Console.WriteLine($"Numero de digitos:{contador}");
    }
}
