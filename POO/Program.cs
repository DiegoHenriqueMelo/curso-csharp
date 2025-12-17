using POO.Models;

Pessoa p1 = new()
{
    Nome = "Diego",
    Idade = 30
};

p1.Apresentar();

ContaCorrente c1 = new(123, 1000M);

// c1.Saldo = 5;

c1.ExibirSaldo();