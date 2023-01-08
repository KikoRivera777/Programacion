namespace Ejercicio8
{
    class Comercial : Empleado
    {
        private const int PLUS = 300;

        private double comision;
        private int edad;

        private double Comision { get => comision; set => comision = value; }
        private int Edad { get => edad; set => edad = value; }

        public Comercial (string nombre, int edad, double salario, double comision) : base(nombre, salario)
        {
            Comision = comision;
            Edad = edad;
        }

        public override void AplicarPlus()
        {
            if (edad > 30 && comision > 200)
            {
                Console.WriteLine($"Plus: {PLUS}");
            }
            else
            {
                Console.WriteLine("No hay plus");
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Edad: {edad}");
            builder.AppendLine($"Comision: {comision}");
            return ToString1() + builder.ToString();
        }

    }
}
