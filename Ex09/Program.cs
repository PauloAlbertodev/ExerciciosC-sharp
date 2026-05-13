namespace Ex09;
    //Escreva um programa que leia o peso e a Altura do usuario, calcule o IMC e exiba o valor 
    // formatado com duas casas decimais
    // formaula: peso/ math.pow(altura,2)
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu peso (kg):");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua Altura (M)");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / Math.Pow(altura,2);
        Console.WriteLine($"Seu IMC é: {imc:F2}"); 
    }
}
