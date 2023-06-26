using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Triangulo
{
    public class Triangulo
    {
        private double lado1 { get; set; }
        private double lado2 { get; set; }
        private double lado3 { get; set; }
        private string tipo { get; set; }
        private double perimetro { get; set; }
        private double area { get; set; }
        

        public Triangulo(double Lado1, double Lado2, double Lado3)
        {
            lado1 = Lado1;
            lado2 = Lado2;
            lado3 = Lado3;
            tipo = "";
            perimetro = 0;
            area = 0;
        }

        private bool isTriangle()
        {
            if((lado1 < lado2 + lado3) && (lado2 < lado1 + lado3) && (lado3 <  lado1 + lado2))
            {
                classificar();
                return true;
            }
            else
            {
                return false;
            }
        }

        private double calcularPerimetro()
        {
            if (isTriangle())
            {
                perimetro = lado1 + lado2 + lado3;
            }
            else
            {
                perimetro = 00;
            }
            return perimetro;
        }

        private void classificar()
        {
            if(lado3 == lado2 && lado2 == lado1)
            {
                tipo = "Triangulo Equilátero";
            }

            else if(lado3 != lado2 && lado2 != lado1)
            {
                tipo = "Triangulo Escaleno";
            }

            else
            {
                tipo = "Triangulo Isóceles";
            }
        }

        private double calcularArea()
        {
            if (isTriangle())
            {
                double sp = perimetro / 2;
                area = Math.Sqrt(sp * (sp - lado1) * (sp - lado2) * (sp - lado3));

            }
            else
            {
                area = 00;
            }
            return area;
        }

        public string resultado()
        {
            string resultado;
            if (isTriangle())
            {
                calcularPerimetro();
                calcularArea();
                classificar();
                resultado = "Lado1: " + lado1 +
                            "\nLado2: " + lado2 +
                            "\nLado3: " + lado3 +
                            "\nPerimetro: " + perimetro +
                            "\nArea: " + area +
                            "\nTipo: " + tipo;
            }

            else
            {
                resultado = "Não é um Triângulo";
            }
            return resultado;
        }
    }
}
