namespace Ex14;
/*Implemente um programa que leia três lados
 (a, b, c) e indique se formam um triângulo. Se formarem,
informe se é equilátero, 
isósceles ou escaleno.
Obs: Forma um triângulo quando a soma de 
quaisquer dois lados é maior do que o terceiro*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o lado1:");
        int lado1 = Convert.ToInt32(Console.ReadLine());        
        Console.WriteLine("Digite o lado2:");
        int lado2 = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Digite o lado3:");
        int lado3 = Convert.ToInt32(Console.ReadLine()); 

        if (lado1+lado2 > lado3 && lado1+lado3 >lado2 && lado2+lado3 > lado1 )
        {
            if (lado1 ==lado2 && lado2 == lado3)
            {
                Console.WriteLine("Equilatero");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Isósceles");
            }
            else
            {
                Console.WriteLine("Escaleno");
            }
            
        }
        else
        {
            Console.WriteLine("Os lados não formam um triangulo");
        }
    }
}
