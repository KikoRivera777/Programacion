namespace Ejercicio4
{
    internal class Electrodomestico
    {
        private const string CONSUMO_ENERGETICO = "F";
        private const string COLOR_DEFAULT = "blanco";
        private const double PRECIO_DEFAULT = 100;
        private const double PESO_DEFAULT = 5;

        private double precioBase;
        private string color;
        private string consumo;
        private double peso;

        public double PrecioBase { get => precioBase; }
        public string Color { get => color; }
        public string Consumo { get => consumo; }
        public double Peso { get => peso; }

        public Electrodomestico(double precioBase, string color, string consumo, double peso)
        {
            this.precioBase = precioBase;
            this.color = color;
            this.consumo = consumo;
            this.peso = peso;
        }
        public Electrodomestico(double precioBase, double peso) : this(precioBase, COLOR_DEFAULT, CONSUMO_ENERGETICO, peso)
        {
        }
        public Electrodomestico() : this(PRECIO_DEFAULT, COLOR_DEFAULT, CONSUMO_ENERGETICO, PESO_DEFAULT)
        {
        }

        public void ComprobarConsumoEnergetico()
        {
            if (consumo == "A") consumo = "A";
            else if (consumo == "B") consumo = "B";
            else if (consumo == "C") consumo = "C";
            else if (consumo == "D") consumo = "D";
            else if (consumo == "E") consumo = "E";
            else if (consumo == "F") consumo = CONSUMO_ENERGETICO;
            else consumo = CONSUMO_ENERGETICO;
        }

        public void ComprobarColor()
        {
            if (color == "blanco") color = COLOR_DEFAULT;
            else if (color == "rojo") color = "rojo";
            else if (color == "negro") color = "negro";
            else if (color == "azul") color = "azul";
            else if (color == "gris") color = "gris";
            else color = COLOR_DEFAULT;

        }

        static void PrecioFinal()
        {

        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Precio: {precioBase}");
            builder.AppendLine($"Color: {color}");
            builder.AppendLine($"Consumo: {consumo}");
            builder.AppendLine($"Peso: {peso}");
            return builder.ToString();
        }
    }
}
