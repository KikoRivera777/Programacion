namespace Ejercicio7
{
    class Serie
    {
        private const int TEMPORADAS = 3;
        private const bool ENTREGADO = false;

        private string titulo;
        private int temporadas;
        private bool entregado;
        private string genero;
        private string creador;

        private string Titulo { get => titulo; set => titulo = value; }
        private int Temporadas { get => temporadas; set => temporadas = value; }
        private string Genero { get => genero; set => genero = value; }
        private string Creador { get => creador; set => creador = value; }

        public Serie (string titulo, int temporadas, bool entregado, string genero, string creador)
        {
            Titulo = titulo;
            Temporadas = temporadas;
            this.entregado = entregado;
            Genero = genero;
            Creador = creador;
        }

        public Serie (string titulo, string creador) : this(string.Empty, TEMPORADAS, ENTREGADO, string.Empty, string.Empty)
        {
        }

        public Serie (string titulo, int temporadas, string genero, string creador)
        {
        }

        public void Entregar()
        {
            entregado = true;
        }

        public void Devolver()
        {
            entregado = false;
        }

        public void EsEntregado()
        {
            Console.WriteLine(entregado);
        }

        public void Contar()
        {
            int x = 0;
            if (entregado = true) x++;

            Console.WriteLine($"Series entregadas{x}");
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Título: {titulo}");
            builder.AppendLine($"Creador: {creador}");
            builder.AppendLine($"Género: {genero}");
            builder.AppendLine($"Temporadas: {temporadas}");
            builder.AppendLine($"Entregado: {entregado}");
            return builder.ToString();
        }
    }
}
