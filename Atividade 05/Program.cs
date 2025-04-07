class program
{
    public static void Main()
    {
        Console.WriteLine("Digite um qualquer número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
        if (num == 0)
        {
            Console.WriteLine("Este numero é zero");
        }

        else if (num <0) 
        {
            Console.WriteLine("Este número é negativo");
        }

        else if(num > 0) 
        {
            Console.WriteLine("Este número é positivo");
        }

    }
}