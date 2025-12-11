using Exemplo_Fundamentos.Models;


// Instancando Objeto
Pessoa p = new();

p.Nome = "Diego";
p.Idade = 20;
p.Apresentar();

// Tipos de Dados

// string
string name = "Diego";
// char
char letter = 'D';
// object
// bool
bool developer = true;
// byte
// decimal
decimal price = 173.87M;
// double
double height = 1.72;
// int
string age = "20";
// float
float salary = 123.45F;
// long
// uint
// não pode valores negativos
// short
// ulong
// não pode valores negativos

Console.WriteLine(name);
Console.WriteLine(letter);
Console.WriteLine(developer);
Console.WriteLine(price);
Console.WriteLine(height);
Console.WriteLine(age);
Console.WriteLine(salary);

int parse = int.Parse("5");
// Não faz tratamento de NULL
int salaryStringToInt = Convert.ToInt32(age);
// Faz tratamento de NULL = 0

string developrBoolToString = developer.ToString();


// Condições

int quantidadeEstoque = 10;

int quantidadeCompra = 4;

if (quantidadeEstoque >= quantidadeCompra)
{
    Console.WriteLine("Venda Realizada");
}
else
{
    Console.WriteLine("Sem quantidade em estoque!");
}
;

Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("VOGAL");
        break;
    default:
        Console.WriteLine("CONSOANTE");
        break;
}
;

// Operadores Lógicos

// OU/OR ||
// E/AND &&
// NÃO/NOT !

// Operadore Aritiméticos

// + -- ADIÇÃO
// - -- SUBTRAÇÃO
// * -- MULTIPLICAÇÃO
// / -- DIVISÃO
// % -- MODULO/RESTO
// ++ -- INCREMENTO
// -- -- DECREMENTO

Calculadora calc = new();

calc.Somar(10, 5);
calc.Subtrair(10, 5);
calc.Multiplicar(10, 5);
calc.Dividir(10, 5);
calc.Modulo(10, 5);
calc.Potencia(3,2);
calc.Raiz(25);
calc.Decremento(10);
calc.Incremento(10);
calc.TabuadaFor(27365);
calc.TabuadaWhile(19);
calc.evenOrOdd(20);