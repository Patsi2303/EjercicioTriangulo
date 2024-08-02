internal class Program
{
    private static void Main(string[] args)
    {
        int a, b, c, cont;
        cont = 0;

        Console.Write("Ingrese el lado A del triangulo: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el lado B del triangulo: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el lado C del triangulo: ");
        c = int.Parse(Console.ReadLine());

        if (a == b)
        {
            cont++;
        }

        if (b == c)
        {
            cont++;
        }

        if (c == a)
        {
            cont++;
        }

        switch (cont)
        {
            case 0:
                Console.WriteLine("\nEl triangulo es escaleno");
                break;
            case 1:
                Console.WriteLine("\nEl triangulo es isosceles");
                break;
            case > 1:
                Console.WriteLine("\nEl triangulo es equilatero");
                break;
            default:
                Console.WriteLine("Ocurrio un error");
                break;
        }

        Console.WriteLine("\nPresione cualquier tecla para terminar");
        Console.ReadKey();
    }
}