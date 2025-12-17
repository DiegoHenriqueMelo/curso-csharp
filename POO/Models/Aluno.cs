using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, int idade, double nota) : base(nome, idade)
        {
            Nota = nota;
        }

        public double _nota { get; set; }


        private double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou um aluno nota {Nota}");
        }
    }


}