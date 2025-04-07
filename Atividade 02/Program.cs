class Program
{
    public static void Main()
    {
        //Atividade 02
        Console.WriteLine("Digite a sua idade:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num <= 17)
        {

            Console.WriteLine("Você é menor de idade");

        }
        else if (num >= 18)
        {

            Console.WriteLine("Você é maior de idade!");

        }
    }
}