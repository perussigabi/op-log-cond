//Ref (5 pontos)2 – Faça um programa que verifique se uma letra digitada é vogal ou consoante. Nome: Gabriele Perussi Silva

public static class AtividadeDois
{
    public static void Executar()
    {
        string letra;

        Console.WriteLine("Digite uma letra:");
        letra = (Console.ReadLine()!);

        Console.Clear();

        if (letra != "a" || letra != "e" || letra != "i" ||  letra != "o" ||  letra != "u")
        {
            Console.WriteLine("Essa letra é uma consoante.");
        }
        else
        {
            Console.WriteLine("Essa letra é um vogal.");
        }
    }
}