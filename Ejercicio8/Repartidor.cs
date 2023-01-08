namespace Ejercicio8
{
    class Repartidor : Empleado
    {
        private const int PLUS = 300;

        private string zona;
        private int edad;

        private string Zona { get => zona; set => zona = value; }
        private int Edad { get => edad; set => edad = value; }

        public Repartidor (string nombre, int edad, double salario, string zona) : base (nombre, salario)
        {
            Zona = zona;
            Edad = edad;
        }

        public override void AplicarPlus()
        {
            if (edad < 25 && zona == "3")
            {
                Console.WriteLine($"Plus: {PLUS}");
            }
            else Console.WriteLine("No hay plus");
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Edad: {edad}");
            builder.AppendLine($"Zona: {zona}");
            return ToString1() + builder.ToString();
        }
    }
}
