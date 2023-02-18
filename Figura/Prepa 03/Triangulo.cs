using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Triangulo : Figura
    {
        private double _base;
        private double _altura;
        private double _lado1;
        private double _lado2;
        public Triangulo(double base_triangulo, double altura, double lado1, double lado2, string color) : base(color)
        {
            _base = base_triangulo;
            _altura = altura;
            _lado1 = lado1;
            _lado2 = lado2;
        }

        public override double GetArea()
        {
            return (_base * _altura) / 2;
        }
        public override double GetPerimetro()
        {
            return _lado1 + _base + _lado2;
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }
    }

    class Isosceles : Triangulo
    {
        public Isosceles(double base_triangulo, double altura, float lado, string color) : base(base_triangulo, altura, lado, lado, color)
        {

        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo Isosceles de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }
    }
    class Escaleno : Triangulo
    {
        public Escaleno(double base_triangulo, double altura, double lado1, double lado2, string color) : base(base_triangulo, altura, lado1, lado2, color)
        {

        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo escaleno de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }

    }
    class Equilatero : Triangulo
    {
        public Equilatero(double altura, double lado, string color) : base(lado, altura, lado, lado, color)
        {

        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo equilatero de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }

    }
}
