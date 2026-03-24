/*Ref. (5 pontos)10 - Escreva um programa que leia um número e verifique se ele é par ou ímpar.Nome: Gabriele Perussi Silva*/
public static class AtividadeDez
{
    public static void Executar()
    {
        int numero;

        Console.WriteLine("Digite um número: ");
        numero = int.Parse(Console.ReadLine()!);
        Console.Clear();

        if ((numero % 2) == 0)
        {
            Console.WriteLine("Esse número é positivo.");
        }
        else
        {
            Console.WriteLine("Esse número é negativo");
        }

    }
}