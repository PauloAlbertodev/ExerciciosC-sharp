namespace Ex19;
/*Implemente um programa que realize uma validação de
 acesso, o programa deverá pedir usuário e senha
(admin / 1234) e se estiverem corretos o usuário deverá ter acesso ao sistema*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o seu usuário:");
        string user = Console.ReadLine();

        Console.WriteLine("Digite uma senha:");
        string senha = Console.ReadLine();

        if (user == "admin" && senha == "1234")
        {
            Console.WriteLine("Login Bem-Secedido!");
        }
        else
        {
            Console.WriteLine("Acesso negado!");
        }
    }
}
