using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuGet.Models
{
    public class Venda
    {

        public Venda()
        {

        }

        public Venda(int id, string produto, decimal preco)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
        }

        public int Id { get; set; }


        private string _produto = string.Empty;
        public string Produto
        {
            get => _produto.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _produto = value;
            }
        }

        public decimal Preco { get; set; }
    }
}