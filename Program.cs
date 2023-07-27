using System.Data;

class array
{
    static void Main(string[] args)
    {
        int[] nota = new int[3];
        Console.WriteLine("Digite a nota um");
        nota[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a nota dois");
        nota[1] = Convert.ToInt32(Console.ReadLine());

        nota[2] = (nota[0] + nota[1]) / 2;

        int resultado = nota[2];
        Console.WriteLine(resultado);
    }
    
}
