// crear en la terminal dotnet new console
using System;
using System.Globalization;

namespace _04_ruta
{ //poner el mismo nombre que en el RootNamespace 
    internal class Ruta
    {
        static void Main(string[] args)
        {
            /*
            Introduzca una ruta: c:\Users\Javier\Documentos\
            Ruta completa: c:\Users\Javier\Documentos\
            Unidad: c:
            Directorio nivel 1: Users
            Directorio nivel 2: Javier
            Directorio nivel 3: Documentos
            */
            string? ruta;

            Console.WriteLine("Introduce la ruta: ");
            ruta = Console.ReadLine();

            //cada vez que haya una barra partirá la ruta
            string[] directorios = ruta.Split(new char[] { '\\' });

            for (int i = 0; i < directorios.Length; i++)
            {
                //para la unidad cogemos la posición 0
                if (i == 0)
                {
                    Console.WriteLine("Unidad: " + directorios[i]);
                }
                Console.WriteLine("Directorio nivel " + (i + 1) + ": " + directorios[i + 1]);
            }

        }
    }
}