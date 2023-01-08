namespace Ejercicio6
{
    class CD
    {
        private Cancion[] canciones = new Cancion[3];
        private int contador = 1;

        public CD (Cancion[] canciones, int contador)
        {
            this.canciones = canciones;
            this.contador = contador;
        }

        public void DameCancion(int x)
        {
            Console.WriteLine(canciones[x]);
        }


    }
}
