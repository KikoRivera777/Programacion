namespace Ejercicio5
{
    class CuentaJoven : Cuenta
    {
        private int edad;
        private string bono;

        public int Edad { get => edad; set => edad = value; }
        public string Bono { get => bono; set => bono = value; }

        public CuentaJoven (string titular, double cantidad, int edad, string bono) : base(titular, cantidad)
        {
            Edad = edad;
            Bono = bono;
        }

        public bool TitularValido(bool valido)
        {
            if (edad > 25) valido = false;
            else valido = true;

            return valido;
        }
    }
}
