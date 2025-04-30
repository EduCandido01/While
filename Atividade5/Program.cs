class Program
{
    static void Main()
    {
        int contador = 0;
        Console.WriteLine("escreva um número:");
        int num = int.Parse(Console.ReadLine());


        while (contador <= num )
        {

            Console.WriteLine(contador);
            contador = contador + 3;
        }
    }
}
