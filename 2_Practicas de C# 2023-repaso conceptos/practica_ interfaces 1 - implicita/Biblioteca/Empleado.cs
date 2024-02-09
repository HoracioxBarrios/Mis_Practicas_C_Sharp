namespace Biblioteca
{
    public class Empleado : Usuario , ISaludar
    {


        

        public Empleado(string nombre) :base(nombre)
        {
            
        
        }

        public void Saludar()
        {
            Console.WriteLine("Hola soy empleado e Hijo"); 
        }
    }
}