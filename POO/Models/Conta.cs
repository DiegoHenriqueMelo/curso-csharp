using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public abstract class Conta
    {
        protected decimal Saldo;

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é: R${Saldo}");
        }


        public abstract void Creditar(decimal valor);
    }
}