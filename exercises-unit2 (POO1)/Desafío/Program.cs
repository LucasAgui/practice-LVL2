using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Agregar Constructor que reciba Modelo y Marca.
            //Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
            //Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
            //Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
            //Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.
            string modelo;
            string marca;
            string contacto;

            Console.WriteLine("Modelo de teléfono: ");
            modelo = Console.ReadLine();
            Console.WriteLine("Marca del teléfono: ");
            marca = Console.ReadLine();
            Telefono t1 = new Telefono(modelo, marca);
            Console.WriteLine("Número de Teléfono: ");
            t1.NumeroTelefonico = Console.ReadLine();
            Console.WriteLine("Código de Operador: ");
            t1.CodigoOperador = int.Parse(Console.ReadLine());
            Console.WriteLine("Estado: ");
            Console.WriteLine("Modelo - " + t1.modelo);
            Console.WriteLine("Marca - " + t1.marca);
            Console.WriteLine("Numero de Teléfono: " + t1.NumeroTelefonico);
            Console.WriteLine("Código de Operador: " + t1.CodigoOperador);
            Console.WriteLine("- En ESPERA -");
            Console.WriteLine("Ingrese un contacto para llamar: ");
            contacto = Console.ReadLine();
            Console.WriteLine(t1.Llamar(contacto));
            Console.ReadKey();
        }
    }
}
