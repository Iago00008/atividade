class program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número de 1 a 7:");
             int num = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if (num == 1)
        {
            Console.WriteLine("Segunda-Feira");
        }
        else if (num == 2)
        {
            Console.WriteLine("Terça_Feira");
        }
        else if (num == 3)
        {
            Console.WriteLine("Quarta-Feira");
        }
        else if (num == 4)
        {
            Console.WriteLine("Quinta-Feira");

        }
        else if (num == 5)
        {
            Console.WriteLine("Sexta-Feira");

        }
        else if (num == 6)
        {
            Console.WriteLine("Sabado");

        }
        else if (num == 7)
        {
            Console.WriteLine("Domingo");

        }
    }
}