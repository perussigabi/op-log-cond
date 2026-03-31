/*Ref (15 pontos)5 - As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. 
Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.Nome:Gabriele Perussi Silva*/

public static class AtividadeCinco
{
    public static void Executar()
    {
        int maca;
        double macaValor = 0;
        double totalDaCompra;

        Console.WriteLine("Quantas maças você irá comprar?");
        maca = int.Parse(Console.ReadLine()!);

        if (maca <= 12)
        {
            macaValor = 0.30;
        }
        else
        {
            macaValor = 0.25;
        }
        totalDaCompra = maca * macaValor;

        Console.WriteLine($"O valor de sua compra é {totalDaCompra:F2}.");
    }
}