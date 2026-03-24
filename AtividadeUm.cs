/*Ref (5 pontos)1 - Faça um programa que calcule e apresente o valor do volume de uma lata,
 sabendo que PI é um valor constante de 3.14159, o programa deve pedir os valores de RAIO e ALTURA,
utilize a fórmula VOLUME = PI * RAIO² * ALTURA.
 Nome: Gabriele Perussi Silva*/

public static class AtividadeUm
{
    public static void Executar()
    {
        double volume;
        double pi = 3.14159;
        double raio;
        double altura;

        Console.WriteLine("Digite o valor do raio da lata: ");
        raio = double.Parse(Console.ReadLine()!);

        Console.WriteLine();

        Console.WriteLine("Digite a altura da lata: ");
        altura = double.Parse(Console.ReadLine()!);

        Console.Clear();

        volume = pi * (raio*raio) * altura;

        Console.WriteLine($"O volume da lata é {volume}.");

    }
}