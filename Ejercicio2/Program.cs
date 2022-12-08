namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Escribe  nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escribe  edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe sexo");
            Persona.Genero sexo = (Persona.Genero)Enum.Parse(typeof(Persona.Genero), Console.ReadLine(), true);
            Console.WriteLine("Escribe peso");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Escribe altura");
            double altura = double.Parse(Console.ReadLine());

            Persona persona1 = new Persona(nombre, edad, sexo, peso, altura);
            Persona persona2 = new Persona(nombre, edad, sexo);
            Persona persona3 = new Persona();

            persona3.Nombre = nombre;
            persona3.Edad = edad;
            persona3.Sexo = sexo;
            persona3.Peso = peso;
            persona3.Altura = altura;

            IndicarPeso(persona1);
            IndicarPeso(persona2);
            IndicarPeso(persona3);

            IndicarEdad(persona1);
            IndicarEdad(persona2);
            IndicarEdad(persona3);
        }

        static void IndicarPeso(Persona persona)
        {
            int imc = persona.CalcularIMC();
            if (imc == Persona.PESO_INFERIOR)
            {
                Console.WriteLine("Le falta peso");
            }
            else if (imc == Persona.PESO_IDEAL)
            {
                Console.WriteLine("Peso ideal");
            }
            else
            {
                Console.WriteLine("Le sobra peso");
            }
        }
        static void IndicarEdad(Persona persona)
        {
            bool esMayor = persona.EsMayorDeEdad();

            if (esMayor)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }
        }
    }
}
