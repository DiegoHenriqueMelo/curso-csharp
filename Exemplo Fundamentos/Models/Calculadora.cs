using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_Fundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Modulo(int x, int y)
        {
            Console.WriteLine($"{x} % {y} = {x % y}");
        }
        public void Potencia(int x, int y)
        {
            Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
        }
        public void Raiz(int x)
        {
            Console.WriteLine($"Raiz de {x} = {Math.Sqrt(x)}");
        }
        public void Incremento(int x)
        {
            Console.WriteLine($"Incrementando {x}");
            int numIncrement = ++x;  // Pré-incremento: incrementa ANTES
            Console.WriteLine($"Resultado: {numIncrement}");
        }
        public void Decremento(int x)
        {
            Console.WriteLine($"Decrementando {x}");
            int numDecrement = --x;  // Pré-decremento: decrementa ANTES
            Console.WriteLine($"Resultado: {numDecrement}");
        }
    }
}