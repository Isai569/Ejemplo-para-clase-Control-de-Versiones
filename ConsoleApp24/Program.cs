using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Caracter_Apellido_Ultimo_Caracter_Nombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string Nombre, Apellidos;
            Console.Write("Escriba su nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Escriba sus apellidos: ");
            Apellidos = Console.ReadLine()
            Console.WriteLine(Nombre.Last() + " " + Apellidos.First());
            Console.WriteLine("Su nombre contiene " + Nombre.Length + " Caracteres");   
            Console.WriteLine("Su nombre contiene " + Apellidos.Length + " Caracteres");   
           
            Console.ReadKey();
        }
    }
}
