namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comercial comercial = new Comercial("Pepe", 35, 400, 150);
            Console.WriteLine(comercial.ToString()); 
            comercial.AplicarPlus();
            Console.WriteLine(" ");

            Comercial comercial2 = new Comercial("Juan", 40, 200, 300);
            Console.WriteLine(comercial2.ToString());
            comercial2.AplicarPlus();
            Console.WriteLine(" ");

            Repartidor repartidor = new Repartidor("Pepe", 19, 100, "3");
            Console.WriteLine(repartidor.ToString());
            repartidor.AplicarPlus();
            Console.WriteLine(" ");

            Repartidor repartidor2 = new Repartidor("Pepe", 30, 100, "1");
            Console.WriteLine(repartidor2.ToString());
            repartidor2.AplicarPlus();
        }
    }
}
