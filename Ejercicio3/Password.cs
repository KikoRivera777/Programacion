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

        public bool EsFuerte()
        {
            bool mayusculas = false, minusculas = false, numeros = false ;

            for (int i = 0; i < contrasena.Length; i++)
            {
                if(char.IsUpper (contrasena, i))
                {
                    mayusculas = true;
                }
                else if(char.IsLower(contrasena, i))
                {
                    minusculas = true;
                }
                else if(char.IsDigit(contrasena, i))
                {
                    numeros = true;
                }
            }
            if(mayusculas && minusculas && numeros)
            {
                return true;
            }
            return false;
        }

        public string GenerarPassword()
        {
            Random random = new Random();
            string creada = " ";
            for(int i = 0; i < longitud ; i++)
            {
                int password = random.Next(0, 9);
                creada += password.ToString();
            }
            return creada;
        }
    }
}
