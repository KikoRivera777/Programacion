namespace Ejercicio5
{
    internal class Persona
    {
        private const string LETTERS = "TRWAGMYFPDXBNJZSQVHLCKE";

        private string nombre;
        private int edad;
        private string dni;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Dni { get => dni; set => dni = value; }

        public Persona(string nombre = "", int edad = 0, string dni = "" )
        {
            Nombre = nombre;
            Edad = edad;
            Dni = CalcularDni();
        }

        public bool EsMayorDeEdad()
        {
            bool mayor = false;
            if (edad > 17)
            {
                mayor = true;
            }
            return mayor;
        }

        public string CalcularDni()
        {
            char letra = ' ';
            try 
            {
                int y = Convert.ToInt32(dni);
                letra = LETTERS[y % LETTERS.Length];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return dni + letra;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Nombre: {Nombre}");
            builder.AppendLine($"Edad: {Edad}");
            builder.AppendLine($"Mayor de edad: {EsMayorDeEdad}");
            builder.AppendLine($"DNI: {Dni}");
            return builder.ToString();
        }

    }
}
