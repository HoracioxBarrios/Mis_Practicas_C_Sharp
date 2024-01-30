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

            //---------------------------- TIPOS DE DATOS ----------------------------
            //---------------------------- TIPOS DE DATOS ---------------------------- 
            //---------------------------- TIPOS DE DATOS ---------------------------- 


            // ----- TIPO DE DATO CADENA DE CARACTERES string -----
            string myString = "Esto es una cadena de texto";
            Console.WriteLine(myString);
            myString = "Cambio el texto en esta linea";
            Console.WriteLine(myString);



            //----- TIPO DE DATO PARA NUMEROS ENTEROS int -----
            int myInt = 7;
            myInt = myInt + 4;
            Console.WriteLine(myInt);// aca vale 11
            Console.WriteLine(myInt - 1);// en tiempo de ejecucion muestra 10, pero nose modifica el valor de la variable realmente
            Console.WriteLine(myInt);// aca vale 11 


            //----- TIPOS DE DATOS PARA NUMEROS FLOTANTES -----
             
            float myFloat = 1.5F;// se usa sufijo F al final para representar un float [longitud menor]
            Console.WriteLine(myFloat);

            double myDouble = 1.5; // [tiene una longitud mayor] es recomandable usar este en su lugar
            Console.WriteLine(myDouble);


            // #OPERACIONES:

            Console.WriteLine(myDouble + myFloat + myInt);// se puede operar porque c# trata a todos como datos numericos


            //----- TIPO DE DATO dynamic -----

            dynamic myDynamic = "Hola";
            Console.WriteLine(myDynamic);// "hola"
            myDynamic = 50;
            Console.WriteLine(myDynamic);// 50
            /* no es recomendable usar dynamyc, porque si uno quiere hacer una 
             operacion con esta variable tendria que estar comprobando que tipo de 
            dato tiene dentro, para hacer dicha operacion*/


            // ----- PALABRA RESERVADA var -----
            var myVar1 = "es una nueva cadena de texto";
            Console.WriteLine(myVar1);
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
            var myVar2 = 100;
            Console.WriteLine(myVar2.GetType()); //System.Int32 ----- aca usamos GetType() que es un metodo que viene de la clase base  System.Object la cual heredan todos los tipos de referencia (clases) y en cuanto a los tipos de valor struct no heredan directamente de object sino que se implementa la interfaz System.ValueType la cual a su vez deriva de System.Object .

            Console.WriteLine(myVar1.GetType()); //System.String

            //myvar1 = 1.5; //da [error]  porque no se puede cambiar el tipo de dato cuando ya se ha inferido arriba en tiempo de ejecucion.
            

            // ----- Tipo de dato Bool -----
            bool myBool = false;

            myBool = true;

            //---------------------------- ******* ---------------------------- 
            //---------------------------- ******* ---------------------------- 
            //---------------------------- ******* ---------------------------- 

            // ----- INTERPOLACION DE STRING -----
            Console.WriteLine($"El valor de mi Entero es {myInt} y el valor de mi boolean es {myBool}");

            // ----- CONSTANTE -----
            const string MyConstante = "Mi constante";// en UpperCamelCase !!!
            Console.WriteLine(MyConstante);



            //---------------------------- ESTRUCTURAS ----------------------------
            //---------------------------- ESTRUCTURAS ----------------------------
            //---------------------------- ESTRUCTURAS ---------------------------- 

            ///****** ARRAY ***** 

            //los arrays (Empiezan en la posicion 0 , 1, 2, 3, 4,etc, hasta la longitud que definamos en la creacion del mismo y dicha longitud no se puede cambiar mas)

            /*
            //Esto da error!

            var myArray = ["Hora", "Barrios", "Practica"];
            Console.WriteLine(myArray);

            //Esto da error!

            var myArray = ["Hora", "Barrios", "Practica"];
            Console.WriteLine(myArray[0]);

            //Esto da error!

            var myArray = new string["Hora", "Barrios", "Practica"];
            Console.WriteLine(myArray[0]);
            */


            /* asi seria correcto (instanciar el array, agregamos los elementos harcodeados )
               y conseguir el primer elemento del array.
            */

            // En C# hay que crearlo con la palabra reservada NEW
            var myArray = new string[] { "Hora", "Barrios", "Practica" };
            Console.WriteLine(myArray[0]);

            /*
            //Esto da error!
            myArray[3] = "Agregame este string";
            Console.WriteLine(myArray[3]);

            Cuando creamos un ARRAY tenemos que definirle la longitud y esta es inalterable!
            por lo tanto ya no podemos agregar mas elementos.
            */

            myArray[2] = "Practicamos"; // SÍ podemos modificar un elemento existente
            Console.WriteLine(myArray[2]);

            /*
            //Esto da error!
            myArray[2] = 30; // No podemos agregar un tipo de dato distinto al tipo de array creado, ya que en este caso es un arrays de strings
          
            Console.WriteLine(myArray[2]);           

            */
            /*
             Dato extra:-
             */

            ///****** DICTIONARY O DICCIONARIOS ***** 
            var myDictionary = new Dictionary<string, int>
            {
                {"Julia", 36 }, // clave en string , valor en entero
                {"Alberto", 65 },
                {"Luis", 15 }
            };
            Console.WriteLine(myDictionary["Alberto"]);// accedemos al diccionario por su clave aca.


        }
    }
}



