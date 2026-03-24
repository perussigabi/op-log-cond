/*Ref. (5 pontos)9 - Escreva um programa que leia um número e verifique se ele é positivo,negativo ou zero.Nome:*/
public static class AtividadeNove
{
    public static void Executar()
    {
        int numero;

        Console.WriteLine("Digite um número:");
        numero = int.Parse(Console.ReadLine()!);
        Console.Clear();

        if (numero > 0)
        {
            Console.WriteLine("Esse número é positivo.");
        }
        else if (numero == 0)
        {
            Console.WriteLine("Esse número é zero.");
        }
        else
        {
            Console.WriteLine("Esse número é negativo.");
        }
    }
}