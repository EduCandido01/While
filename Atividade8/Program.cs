class Program
{
    static void Main()
    {
        Console.WriteLine("escreva um número:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Resultado");

        int contador = 1;
       int resultado = 0;
        while (contador <= 10)
        {
           resultado = resultado + num;
           contador = contador + 1;      
        }

        Console.WriteLine(resultado);
    }
}
