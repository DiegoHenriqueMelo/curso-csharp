using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome, int idade, float salary) : base(nome, idade)
        {
            Salary = salary;
        }

        public float Salary { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou um(a) professor(a) e recebo {Salary}");
        }
    }
}