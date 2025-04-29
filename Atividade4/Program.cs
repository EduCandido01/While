class Program
{
    static void Main()
    {
        Console.WriteLine("escreva um número:");
        int num = int.Parse(Console.ReadLine());

        int contador = 2;
        while (contador <= num)
        {

            Console.WriteLine(num);
            num = num % 2 == 0;
            
        }
    }
}
