/*Ref. (10 pontos)6 - Um programa deve ler três ângulos e verificar qual é o tipo de triângulo formado.
Primeiro, é necessário conferir se a soma dos três ângulos é igual a 180°, pois só assim eles formam um triângulo.
Depois, se um dos ângulos for igual a 90°, o triângulo é retângulo. Se um dos ângulos for maior que 90°, ele é obtusângulo. 
Caso contrário, se os três forem menores que 90°, o triângulo é acutângulo.Nome:Gabriele Perussi Silva*/

public static class AtividadeSeis
{
    public static void Executar()
    {
        double ang1;
        double ang2;
        double ang3;

        Console.WriteLine("Digite o primeiro ângulo: ");
        ang1 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o segundo ângulo: ");
        ang2 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o terceiro o ângulo: ");
        ang3 = double.Parse(Console.ReadLine()!);

        if ((ang1 + ang2 + ang3) == 180)
        {
            Console.WriteLine("É um triângulo.");
            Console.Clear();
            if (ang1 == 90 || ang2 == 90 || ang3 == 90)
            {
                Console.WriteLine("Esse é um triângulo retângulo.");
            }
            else if (ang1 > 90 || ang2 > 90 || ang3 > 90)
            {
                Console.WriteLine("Esse é um triângulo obtusângulo.");
            }
            else
            {
                Console.WriteLine("Esse triângulo é acutângulo.");
            }
        }
        else
        {
            Console.WriteLine("Erro! Não é possível formar um triângulo.");
            Console.Clear();
        }
    }
}