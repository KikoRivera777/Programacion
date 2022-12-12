namespace Ejercicio3
{
    class Password
    {
        private int longitud;
        private string contrasena;

        public int Longitud { get => longitud; set => longitud = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }

        public Password (string contrasena, int longitud = 8)
        {
            Longitud = longitud;
            Contrasena = GenerarPassword();
        }

        public Password (int longitud) : this (string.Empty, longitud)
        {
        } 

        public bool EsFuerte()
        {
            int mayusculas = 0, minusculas = 0, numeros = 0;

            for (int i = 0; i < contrasena.Length; i++)
            {
                if (char.IsUpper(contrasena, i))
                {
                    mayusculas++;
                }
                else if (char.IsLower(contrasena, 2))
                {
                    minusculas++;
                }
                else if (char.IsDigit(contrasena, 5))
                {
                    numeros++;
                }
            }
            if (mayusculas > 2 && minusculas > 1 && numeros > 5)
            {
                return true;
            }
            return false;
        }

        public string GenerarPassword()
        {
            Random random = new Random();
            Random random1 = new Random();
            string creada = " ";
            for(int i = 0; i < longitud ; i++)
            {
               int numeros = random.Next(0, 9);
                int letras = random1.Next(65, 122);
                char letra = Convert.ToChar(letras);
                creada += numeros.ToString() + letra.ToString();
            }
            return creada.ToString();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Longitud: {longitud}");
            builder.AppendLine($"Contraseña: {contrasena}");
            builder.AppendLine($"{ EsFuerte()}");
            return base.ToString();
        }
    }
}
