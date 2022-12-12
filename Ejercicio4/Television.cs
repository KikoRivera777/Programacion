namespace Ejercicio4
{
    internal class Television : Electrodomestico 
    {
        private const int RESOLUCION_DEFAULT = 20;
        private const bool SINTONIZADOR_DEFAULT = false;
        private const string CONSUMO_ENERGETICO = "F";
        private const string COLOR_DEFAULT = "blanco";
        private const double PRECIO_DEFAULT = 100;
        private const double PESO_DEFAULT = 5;

        private int resolucion;
        private bool sintonizador;

        public int Resolucion { get => resolucion; }
        public bool Sintonizador { get => sintonizador; }

        public Television (double precioBase, string color, string consumo, double peso, int resolucion, bool sintonizador) : base (precioBase, color, consumo, peso)
        {
            this.resolucion = resolucion;
            this.sintonizador = sintonizador;
        }

        public Television (double precioBase, double peso) : base (precioBase, peso)
        {
        }

        public Television() : this(PRECIO_DEFAULT, COLOR_DEFAULT, CONSUMO_ENERGETICO, PESO_DEFAULT, RESOLUCION_DEFAULT, SINTONIZADOR_DEFAULT)
        {
        }

        public override void ComprobarColor()
        {
            base.ComprobarColor();
        }

        public override void ComprobarConsumoEnergetico()
        {
            base.ComprobarConsumoEnergetico();
        }

        public override double PrecioFinal()
        {
            return base.PrecioFinal();

            double result = 0;
            double precioFinal;
            if (resolucion > 40) result += PrecioFinal() * 30 / 100;

            if (sintonizador == true) result += PrecioFinal() + 50;

            return precioFinal = result;
        }
    }
}
