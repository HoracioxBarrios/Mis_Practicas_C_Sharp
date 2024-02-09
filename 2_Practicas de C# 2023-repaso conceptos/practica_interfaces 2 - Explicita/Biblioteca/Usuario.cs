namespace Biblioteca
{
    public class Usuario : ISaludarUno , ISaludarDos
    {
        private string _nombre;
        public Usuario(string nombre) 
        {
            _nombre = nombre;
        }

        string ISaludarUno.Saludar()
        {
            return $"Hola soy {_nombre}";
        }

        void ISaludarDos.Saludar()
        {
            Console.WriteLine("saludar sin retorno"); ;
        }

        public string Nombre 
        {
            get { return _nombre; }
            set { _nombre = value; }
        
        }
    }
}