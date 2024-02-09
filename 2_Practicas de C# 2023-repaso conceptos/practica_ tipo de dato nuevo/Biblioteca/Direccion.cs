namespace Biblioteca
{
    public class Direccion
    {
        public string? Ciudad {  get; set; }

        public string? Calle { get; set; }

        public string? Estado { get; set; }

        public string? CodigoPostal { get; set; }




        public override string ToString()
        {
            // Aquí puedes definir cómo quieres que se vea la dirección como cadena
            return $"Calle: {Calle}, Ciudad: {Ciudad}, Estado: {Estado}, Código Postal: {CodigoPostal}";
        }

    }



}