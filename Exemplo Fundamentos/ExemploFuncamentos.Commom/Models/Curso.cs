using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Curso
    {

        private string _nome = string.Empty;
        public string Nome
        {
            get => _nome;
            set
            {
                 if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public List<Pessoa> Alunos { get; set; } = new List<Pessoa>();


        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObertAlunos()
        {
            int qtd = Alunos.Count;
            return qtd;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);

        }

        public void ListarAluno()
        {
            foreach (Pessoa a in Alunos)
            {
                a.Apresentar();
            }
        }

        public override string ToString()
        {
            return $"Nome do Curso: {Nome}";
        }
    }
}