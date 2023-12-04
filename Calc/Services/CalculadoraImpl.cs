using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calc.Services
{
    public class CalculadoraImpl
    {
        public double Somar (double n1, double n2){
            return n1 + n2;
        }
        public double Subtrair (double n1, double n2){
            return n1 - n2;
        }
        public double Multiplicar (double n1, double n2){
            return n1 * n2;
        }
        public double Dividir (double n1, double n2){
            return n1 / n2;
        }
        public double Exp (double n1, double n2){
            return Math.Pow(n1, n2);
        }
        public double Modulus(double n1, double n2){
            return n1 % n2;
        }
        public bool isPar(int num){
            return num % 2.0 == 0.0;
        }
    }
}