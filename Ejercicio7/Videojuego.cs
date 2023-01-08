namespace Ejercicio7
{
    class Videojuego : IEntregable
    {
        private const int HORAS = 10;
        private const bool ENTREGADO = false;

        private string titulo;
        private int horas;
        private bool entregado;
        private string genero;
        private string company;

        private string Titulo { get => titulo; set => titulo = value; }
        private int Horas { get => horas; set => horas = value; }
        private string Genero { get => genero; set => genero = value; }
        private string Company { get => company; set => company = value; }

        public Videojuego (string titulo, int horas, bool entregado, string genero, string company)
        {
            Titulo = titulo;
            Horas = horas;
            this.entregado = entregado;
            Genero = genero;
            Company = company;
        }

        public Videojuego (string titulo, int horas) : this (string.Empty, HORAS, ENTREGADO, string.Empty, string.Empty)
        {
        }

        public Videojuego(string titulo, int horas, string genero, string company)
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

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Título: {titulo}");
            builder.AppendLine($"Compañía: {company}");
            builder.AppendLine($"Género: {genero}");
            builder.AppendLine($"Horas: {horas}");
            builder.AppendLine($"Entregado: {entregado}");
            return builder.ToString();
        }
    }
}
