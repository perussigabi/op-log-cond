/*Ref. (15 pontos)7 - Para doar sangue é necessário ter entre 18 e 67 anos e possuir mais de 60 kg.
Faça um aplicativo que pergunte a idade de uma pessoa e seu peso e diga se ela pode doar sangue ou não; caso não possa, diga o(s) motivo(s).
Nome: Gabriele Perussi Silva*/
public static class AtividadeSete
{
    public static void Executar()
    {
        double peso;
        int idade;

        Console.WriteLine("Digite a sua idade: ");
        idade = int.Parse(Console.ReadLine()!);
        Console.Clear();

        Console.WriteLine("Digite o seu peso: ");
        peso = double.Parse(Console.ReadLine()!);

        if (idade >= 18 && idade <= 67)
        {
            if (peso > 60)
            {
                Console.WriteLine("Você pode doar sangue!");
            }
            else
            {
                Console.WriteLine("Você não possui o peso ideal para poder doar sangue!");
            }
        }
        else
        {
            if (peso > 60)
            {
                Console.WriteLine("Você possui o peso ideal, mas, não possui a idade ideal. Então, você não pode doar sangue!");
            }
            else
            {
                Console.WriteLine("Você não possui nem o peso ideal e nem a idade ideal para doar sangue!");
            }
        }
    }
}