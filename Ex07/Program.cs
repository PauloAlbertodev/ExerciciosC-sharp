namespace Ex07;
         //Escreva um programa que leia o primeiro nome e o sobrenome do usuario e mostre o 
         // nome completo e seu tamanho total de caracteres.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Primeiro nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Segundo nome:");
        string sobrenome = Console.ReadLine();
        
       string nomeCompleto = nome + " " + sobrenome;
       Console.WriteLine("Nome completo: " + nomeCompleto);
       Console.WriteLine("Total de caracteres: " + nomeCompleto.Length);
       

    }
}
