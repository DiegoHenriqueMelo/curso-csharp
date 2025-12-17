using POO.Models;

// Pessoa p1 = new()
// {
//     Nome = "Diego",
//     Idade = 30
// };

// p1.Apresentar();

ContaCorrente c1 = new(123, 1000M);

// c1.Saldo = 5;

c1.ExibirSaldo();

Aluno a1 = new("Diego", 20, 10.0);

a1.Apresentar();

Professor p1 = new("Marina", 44, 1000F);

p1.Apresentar();