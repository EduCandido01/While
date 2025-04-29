class Program
{
    static void Main()
    {
        Console.WriteLine("escreva um número:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("escreva outro número:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Resultado");

        while (num <= num2)
        {
            
            Console.WriteLine(num);
            num = num + 1;
        }
    }
}
