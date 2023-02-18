using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Luis
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo_cuadrado = new Cuadrado(5, "azul");
            Rectangulo rectangulo = new Rectangulo(2,3, "blanco");

            Figura figura1 = rectangulo_cuadrado;
            Figura figura2 = rectangulo;

            Figura figura3 = new Circulo(2, "negro");
            Figura figura4 = new Triangulo(7, 4.03, 3, 6, "rojo");
            Figura figura5 = new Isosceles(10, 8, 5, "verde");
            Figura figura6 = new Escaleno(13, 7.371, 12.01, 10.89, "amarillo");
            Figura figura7 = new Equilatero(8.66, 10, "naranja");


            figura1.MostrarDatos();
          
            figura2.MostrarDatos();
           
            figura3.MostrarDatos();
         
            figura4.MostrarDatos();

            figura5.MostrarDatos();
            
            figura6.MostrarDatos();
            
            figura7.MostrarDatos();



            Console.ReadLine();
           
            
        }
    }
}
