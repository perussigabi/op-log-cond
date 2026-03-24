/*Ref. (10 pontos)3 - Escreva um programa que receba três números inteiros e mostre eles em ordem crescente.Nome: Gabriele Perussi Silva*/

public static class AtividadeTres
{
    public static void Executar()
    {
        int x;
        int y;
        int w;
        

        Console.WriteLine("Digite o primeiro número: ");
        x = int.Parse(Console.ReadLine()!);
        Console.Clear();

        Console.WriteLine("Digite o segundo número: ");
        y = int.Parse(Console.ReadLine()!);
        Console.Clear();

        Console.WriteLine("Digite o terceiro número: ");
        w = int.Parse(Console.ReadLine()!);
        Console.Clear();

        int maior = 0;
        int meio = 0;
        int menor = 0;
//começo
        //Condição pra Y
        if (y > x || y > w)
        {
            if (y > x && y > w)
            {
                maior = y;
            }
            else 
        {
            meio = y;
        }
        }
        else
        {
            menor = y;
        }
//fim
        //Condição pra W
        if (w > x || w > y)
        {
            if (w > x && w > y)
            {
                maior = w;
            }
            else 
        {
            meio = w;
        }
        }
         else
        {
            menor = w;
        }
        
        //Condição pra X
        if (x > y || x > w)
        {
            if (x > y && x > w)
            {
                maior = x;
            }
            else 
        {
            meio = x;
        }
        }
         else
        {
            menor = x;
        }

        Console.WriteLine($"Os valores em ordem crescente são {menor}, {meio}, {maior}.");



    }
}