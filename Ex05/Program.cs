namespace Ex05;
                 /*Escreva um programa que leia uma quantidade
                  de horas digitada pelo usuário como texto,
                  converta o valor para double, 
                  e depois converta esse valor para minutos e segundos.*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma quantidade de horas: ");
        string textoHoras = Console.ReadLine();

        double horas = double.Parse(textoHoras);
         
        int minutos = (int)(horas*60);
        int segundos = (int)(horas*3600);
        Console.WriteLine($"Horas digitadas:{horas}");
        Console.WriteLine($"Em minutos:{minutos}");
        Console.WriteLine($"Em segundos:{segundos}");



    }
}
