namespace Ex02;

class Program
        //Escreva um programa que leia três notas (decimais) e mostre a média, formatando a saída.
{
    static void Main(string[] args)
    {    
       Console.WriteLine("Digite a primeira nota;");
       double nota1 = double.Parse(Console.ReadLine());

       Console.WriteLine("Digite a segunda nota;");
       double nota2 = double.Parse(Console.ReadLine());

       Console.WriteLine("Digite a terceira nota;");
       double nota3 = double.Parse(Console.ReadLine());

       double media = (nota1+nota2+nota3)/3;

       Console.WriteLine($"Média: {media:F1}.");



    }
}
