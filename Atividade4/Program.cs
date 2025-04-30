class Program
{
    static void Main()
    {
        int contador = 2;

        Console.WriteLine("escreva um número:");
        int num = int.Parse(Console.ReadLine());

        
        while (contador <= num)
        { 
            if (contador % 2 == 0)
            {
                Console.WriteLine(contador);
            }
            contador = contador + 1;
        }
    }
}
