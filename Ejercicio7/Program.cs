namespace Ejercicio7
{
    internal class Program
    {
        static void Main()
        {
            Serie[] serie = new Serie[5];
            Videojuego[] videojuego = new Videojuego[5];

            serie[0] = new Serie("Pepe", 4, false, "terror", "Juanito");
            serie[1] = new Serie("Pepe2", 3, true, "accion", "Juanito");
            serie[2] = new Serie("Pepe3", 1, false, "misterio", "Juanito");
            serie[3] = new Serie("Pepe4", 4, false, "fantasía", "Juanito");
            serie[4] = new Serie("Pepe5", 6, false, "comedia", "Juanito");

            serie[3].Entregar();
            serie[4].Entregar();

            //Console.WriteLine(serie[0].ToString());
            //Console.WriteLine(serie[1].ToString());
            //Console.WriteLine(serie[2].ToString());
            Console.WriteLine(serie[3].ToString());
            Console.WriteLine(serie[4].ToString());

            videojuego[0] = new Videojuego("Sekiro", 28, false, "soul", "FromSoftware");
            videojuego[1] = new Videojuego("Blasphemous", 20, false, "indie", "The Game Kitchen");
            videojuego[2] = new Videojuego("Doom", 17, true, "shooter", "Bethesda");
            videojuego[3] = new Videojuego("The Last Of Us", 15, false, "survival/acción", "Naughty Dog");
            videojuego[4] = new Videojuego("GOW III", 10, true, "acción", "Santa Monica");

            videojuego[0].Entregar();
            videojuego[3].Entregar();

            Console.WriteLine(videojuego[0].ToString());
            //Console.WriteLine(videojuego[1].ToString());
            //Console.WriteLine(videojuego[2].ToString());
            Console.WriteLine(videojuego[3].ToString());
            //Console.WriteLine(videojuego[4].ToString());


        }
    }
}
