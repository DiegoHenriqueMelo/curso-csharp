using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Pessoa
    {

        public Pessoa(){

        }

        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        private string _nome = string.Empty;
        public string Nome
        {
            get => _nome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        private string _sobrenome = string.Empty;
        public string Sobrenome
        {
            get => _sobrenome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _sobrenome = value;
            }
        }


        public string NomeCompleto => $"{Nome} {Sobrenome}";

        private int _idade;
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto}, e tenho {Idade} anos");
        }

    }
}