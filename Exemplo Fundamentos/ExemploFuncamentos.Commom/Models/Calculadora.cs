using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_Fundamentos.Common.Models
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

        // Estruturas de Repetição
        public void TabuadaFor(int x)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{x} * {i} = {x * i}");
            }
        }

        public void TabuadaWhile(int x)
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine($"{x} * {i} = {x * i}");
                i++;
            }
        }

        public void evenOrOdd(int x)
        {
            int i = 0;
            do
            {
                if (i == 0)
                {
                    Console.WriteLine($"{i} é: NULO");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} é: PAR");
                }
                else
                {
                    Console.WriteLine($"{i} é: IMPAR");
                }
                i++;
            } while (i <= x);
        }
    }
}