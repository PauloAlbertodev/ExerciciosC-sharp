namespace Ex15;
/*Implemente um programa que simule uma operação
bancária de levantamento de dinheiro,o programa
deve pedir o saldo da conta e o
valor a levantar e verificar se o mesmo é possível*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu saldo da conta:");
        double saldo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor a levantar:");
        double valor  = Convert.ToInt32(Console.ReadLine());

        if (valor <= 0 )
        {
            Console.WriteLine("Valor inválido");
        }
        else if (valor <= saldo)
        {
            Console.WriteLine("Levantamento autorizado");
        }
        else
        {
            Console.WriteLine("Saldo Insuficiente!");
        }
        
        
    }
}
