
class program
{
    public static void Main()
    {
        Console.WriteLine("Digite sua nota:");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if (num >= 9)
        {
            Console.WriteLine("Nota: A");
        }
        else if (num >= 7)
        {
            Console.WriteLine("Nota: B ");
            
        }
        else if (num >= 5) 
        {
            Console.WriteLine("Nota: C");
                }
        else if (num <5) 
        {
            Console.WriteLine("Nota: D");
                }
    }
}