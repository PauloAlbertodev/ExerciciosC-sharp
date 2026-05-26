namespace Ex20;
/*Implemente uma calculadora, o usuário
 deve digitar dois números e uma operação e o programa deverá
aplicar a operação nos números e mostrar o resultado*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro numero:");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero:");
        int n2 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Digite uma operação (+,-,*,/):");
        char op = Char.Parse(Console.ReadLine());

        if (op == '+')
        {
            Console.WriteLine($"Soma = {n1+n2}");
        }
        else if (op =='-' )
        {
            Console.WriteLine($"Soma = {n1-n2}");
        }
        else if (op =='*' )
        {
            Console.WriteLine($"Soma = {n1*n2}");
        }
        else if (op =='/' )
        {  if(n2 ==0)
            {
            Console.WriteLine("ERRO: Divisão por zero");
            }
            else
            {
            Console.WriteLine($"Divisão = {n1/n2}");
            }    
        }
        else
        {
            Console.WriteLine("Operação inválida!");
        }

        
        
    }
}
