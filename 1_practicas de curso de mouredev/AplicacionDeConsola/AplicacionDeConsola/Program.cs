using System;// espacio de nombre System que tiene clases y metodos que se pueden usar en este caso el metodo Console

namespace AplicacionDeConsola // espaco de nombre que creamos (el nuestro)
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola C# 2024"); //si no incluyesemos el 'using System' tendrimos que escribir: System.Console.WriteLine()
            // para comentar en una linea se usa doble barra así.

            /*para
             comentar
            multilinea
            se usa la barra y el asterisco
            así.
            
            Algo importante es que lo que se comenta no es tomado por 
            el compilador como codigo, sino que lo ignora
            */


            // string es un tipo de datos de cadena de texto o cadena de caracteres
            string myString = "Esto es una cadena de texto";
            Console.WriteLine(myString);
            myString = "Cambio el texto en esta linea";
            Console.WriteLine(myString);



            //int es un tipo de datos de numeros enteros
            int myInt = 7;
            myInt = myInt + 4;
            Console.WriteLine(myInt);// aca vale 11
            Console.WriteLine(myInt - 1);// en tiempo de ejecucion muestra 10, pero nose modifica el valor de la variable realmente
            Console.WriteLine(myInt);// aca vale 11 


            //tipo de dato para numeros flotantes

            float myFloat = 1.5F;// se usa sufijo F al final para representar un float [longitud menor]
            Console.WriteLine(myFloat);

            double mydouble = 1.5; // [tiene una longitud mayor] es recomandable usar este en su lugar
            Console.WriteLine(mydouble);


            // #Operaciones

            Console.WriteLine(mydouble + myFloat + myInt);// se puede operar porque c# trata a todos como datos numericos


            //tipo de dato dynamic

            dynamic myDynamic = "Hola";
            Console.WriteLine(myDynamic);// "hola"
            myDynamic = 50;
            Console.WriteLine(myDynamic);// 50
            /* no es recomendable usar dynamyc, porque si uno quiere hacer una 
             operacion con esta variable tendria que estar comprobando que tipo de 
            dato tiene dentro, para hacer dicha operacion*/


            // Palabra reservada var
            var myvar1 = "es una nueva cadena de texto";
            Console.WriteLine(myvar1);
            /*
             * var infiere el tipo de dato en este caso que es string
             
             * Es importante tener en cuenta que la inferencia de tipo con var no 
             * significa que la variable sea de un tipo dinámico. El tipo de dato 
             * se determina en tiempo de compilación, y una vez que la variable ha 
             * sido declarada e inicializada, su tipo es fijo.
             */


            //myString2 = 150; // esto da el siguiente error:

            /*Gravedad	Código	Descripción	Proyecto	Archivo	Línea	Estado suprimido
            Error	CS0029	No se puede convertir implícitamente el tipo 
            'int' en 'string'	AplicacionDeConsola	C:\Users\xxxxxx\Desktop\Practicas_C_Sharp\1_practicas de curso de mouredev\AplicacionDeConsola\AplicacionDeConsola\Program.cs	75	Activo
*/
            var myvar2 = 100;
            Console.WriteLine(myvar2.GetType()); //System.Int32 ----- aca usamos GetType() que es un metodo que viene de la clase base  System.Object la cual heredan todos los tipos de referencia (clases) y en cuanto a los tipos de valor struct no heredan directamente de object sino que se implementa la interfaz System.ValueType la cual a su vez deriva de System.Object .

            Console.WriteLine(myvar1.GetType()); //System.String

            //myvar1 = 1.5; //da [error]  porque no se puede cambiar el tipo de dato cuando ya se ha inferido arriba en tiempo de ejecucion.
            

            // Tipo de dato Bool
            bool mybool = false;

            mybool = true;


        }
    }
}



