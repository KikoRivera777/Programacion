namespace Ejercicio8
{
    abstract class Empleado
    {
        private string nombre;
        private double salario;

        public Empleado (string nombre, double salario)
        {
            this.nombre = nombre;
            this.salario = salario;
        }

        public abstract void AplicarPlus();

        public virtual string ToString1()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Nombre: {nombre}");
            builder.AppendLine($"Salario: {salario}");
            return builder.ToString();
        }
    }
}
