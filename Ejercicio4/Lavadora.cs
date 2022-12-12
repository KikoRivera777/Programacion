namespace Ejercicio4
{
    internal class Lavadora : Electrodomestico
    {
        private const double CARGA_DEFAULT = 5;
        private const string CONSUMO_ENERGETICO = "F";
        private const string COLOR_DEFAULT = "blanco";
        private const double PRECIO_DEFAULT = 100;
        private const double PESO_DEFAULT = 5;

        private double carga;

        private double Carga { get => carga; }

        public Lavadora (double precioBase, string color, string consumo, double peso, double carga) : base(precioBase, color, consumo, peso)
        {
            this.carga = carga;
        }

        public Lavadora (double precioBase, double peso) : base (precioBase, peso)
        {
        }

        public Lavadora () : this (PRECIO_DEFAULT, COLOR_DEFAULT, CONSUMO_ENERGETICO, PESO_DEFAULT, CARGA_DEFAULT)
        {
        }

        public override double PrecioFinal()
        {
            base.PrecioFinal();

            double result = 0;
            double precioFinal;
            if (carga > 30) result = 50;

            return precioFinal = result + PrecioFinal();
        }

        public override void ComprobarColor()
        {
            base.ComprobarColor();
        }

        public override void ComprobarConsumoEnergetico()
        {
            base.ComprobarConsumoEnergetico();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            //builder.AppendLine($"Precio: {PrecioFinal()}");
            builder.AppendLine($"Color: {ComprobarColor}");
            return builder.ToString();
        }
    }
}
