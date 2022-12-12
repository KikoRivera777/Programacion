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

        //public bool EsFuerte()
        //{
        //    bool mayusculas = false, minusculas = false, numeros = false ;

        //    for (int i = 0; i < contrasena.Length; i++)
        //    {
        //        if(char.IsUpper (contrasena, i))
        //        {
        //            mayusculas = true;
        //        }
        //        else if(char.IsLower(contrasena, i))
        //        {
        //            minusculas = true;
        //        }
        //        else if(char.IsDigit(contrasena, i))
        //        {
        //            numeros = true;
        //        }
        //    }
        //    if(mayusculas && minusculas && numeros)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

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
