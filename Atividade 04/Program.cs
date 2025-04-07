class program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número de 1 a 7:");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
        switch  (num)
        {
            case 1: Console.WriteLine("Segunda-Feira"); break;
            case 2: Console.WriteLine("Terça-Feira"); break;
            case 3: Console.WriteLine("Quarta-Feira"); break;
            case 4: Console.WriteLine("Quinta-Feira"); break;
            case 5: Console.WriteLine("Sexta-Feira"); break;
            case 6: Console.WriteLine("Sabado"); break;
            case 7: Console.WriteLine("Domingo"); break;
            default: Console.WriteLine("Este número não existe"); break;



        }
 


    }
}