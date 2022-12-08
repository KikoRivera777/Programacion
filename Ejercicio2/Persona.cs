namespace Ejercicio2
{
    internal class Persona
    {
        public enum Genero { Hombre, Mujer };
        public const int PESO_INFERIOR = -1;
        public const int PESO_IDEAL = 0;
        public const int PESO_SUPERIOR = 1;
        private const string DNI_LETTERS = "TRWAGMYFPXBNJZSQVHLCKE";

        private const Genero SEXO_POR_DEFECTO = Genero.Hombre;
        private string nombre;
        private int edad;
        private Genero sexo;
        private string dni;
        public double peso;
        public double altura;

        public string Nombre { set => nombre = value; }
        public int Edad { set => edad = value; }
        public Genero Sexo { set => sexo = value; }
        public string Dni { set => dni = value; }
        public double Peso { set => peso = value; }
        public double Altura { set => altura = value; }

        public Persona(string nombre, int edad, Genero sexo, double peso, double altura)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Peso = peso;
            Altura = altura;
            dni = GenerarDni();
        }

        public Persona(string nombre, int edad, Genero sexo) : this(nombre, edad, sexo, 0, 0)
        {
        }

        public Persona() : this(String.Empty, 0, SEXO_POR_DEFECTO)
        {
        }

        public int CalcularIMC()
        {
            int result = PESO_IDEAL;
            double imc = peso / (altura * altura);

            if (imc < 20)
            {
                result = PESO_INFERIOR;
            }
            else if (imc > 25)
            {
                result = PESO_SUPERIOR;
            }

            return result;
        }

        public bool EsMayorDeEdad()
        {
            return edad >= 18;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Nombre: {nombre}");
            builder.AppendLine($"Edad: {edad}");
            builder.AppendLine($"Sexo: {sexo}");
            builder.AppendLine($"DNI: {dni}");
            builder.AppendLine($"Peso: {peso}");
            builder.AppendLine($"Altura: {altura}");

            return base.ToString();
        }
        private string GenerarDni()
        {
            int numero = GenerarNumeroAleatorio();
            char letra = DNI_LETTERS[numero % DNI_LETTERS.Length];
            return numero.ToString() + letra;
        }

        private int GenerarNumeroAleatorio()
        {
            Random random = new Random();
            return random.Next(10000000, 1000000000);
        }
    }
}
