namespace Biblioteca
{

    //modificador de acceso  (public)
    public class Persona
    {

        private string _nombre;
        private string _apellido;





        public Persona(string nombre)// constructor
        {
            _nombre = nombre;
        }

        public Persona(string nombre, string apellido)//sobrecarga de constructor
        {

            _nombre = nombre;
            _apellido = apellido;
        }

        public void Hablar()
        {
            Console.WriteLine("Hola soy una Persona");
        }
        public void Hablar(string mensaje)// sobrecarga met
        {
            Console.WriteLine(mensaje);
        }
        public void Hablar(string mensaje, string nombre)
        {
            Console.WriteLine($"Mensaje {mensaje} nombre {nombre}");
        }

        public virtual string Saludar()
        {
            return "Hola";
        }
        public virtual  string Saludar(string nombre)
        {
            return $"Hola {nombre}";
        }
        public virtual string Saludar(string mensaje,  string apellido, string nombre)
        {
            return "sdfsdfsdfsdf";
        }
        





        public string Nombre
        {

        get { return _nombre; }

        set { _nombre = value; }

        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }


        //public string GetNombre()
        //{
        //    return _nombre;
        //}
        //public void SetNombre(string nombre)
        //{
        //    _nombre = nombre;
        //}
        //public string GetApellido()
        //{
        //    return _apellido;
        //}
        //public void SetApellido(string apellido)
        //{
        //    _apellido = apellido;
        //}



    }
}