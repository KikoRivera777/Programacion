namespace Ejercicio5
{
    class Cuenta
    {
        private string titular;
        private double cantidad;

        public string Titular { get => titular; set => titular = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }

        public Cuenta (string titular, double cantidad)
        {
            Titular = titular;
            Cantidad = cantidad;
        }

        public void Ingresar(double ingresado)
        {
            double cant;
            if (ingresado > 0)
            {
                cant = cantidad + ingresado;
            }
            else
            {
                cant = cantidad;
            }
            Console.WriteLine(cant);

        }

        public void Retirar(double retirado)
        {
            double cant;
            cant = cantidad - retirado;
            Console.WriteLine(cant);
        }
    }
}
