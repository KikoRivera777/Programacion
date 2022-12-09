namespace Ejercicio3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Cuantas contraseñas deseas");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Password[] password = new Password[cantidad];

            Console.WriteLine("Indica la longitud deseada");
            int longitud = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(password);
            }
        }
    }
}
