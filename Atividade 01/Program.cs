class program
{
    public static void Main()
    {
        //Atividade 01
        Console.WriteLine("digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine($"O número {num} é Par!");

        }
        else
        {
            Console.WriteLine($"O número {num} é ímpar!");
        }
    }
}