class program
{
    public static void Main()
    {
        bool maior = 20 > 10;
        bool maiorOUigual = 20 >= 10;
        bool menor = 20 < 30;
        bool menorOUigual = 20 <= 30;
        bool igual = 20 == 20;
        bool diferente = 20 != 10;

        Console.WriteLine(maior);
        Console.WriteLine(maiorOUigual);
        Console.WriteLine(menor);
        Console.WriteLine(menorOUigual);
        Console.WriteLine(igual);
        Console.WriteLine(diferente);


        Console.WriteLine("Digite um número: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        bool maiorDeIdade = idade >= 18;

        Console.WriteLine(maiorDeIdade);
    }
}