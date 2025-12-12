using ExemploFundamentos.Common.Models;


try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivo.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Aconteceu uma exceção genérica: {ex.Message}");
}
finally
{
    Console.WriteLine("Fim da execução!");
}





// Instancando Objeto
Pessoa p = new Pessoa("Diego", "Melo", 20);

Pessoa p1 = new Pessoa("Milena", "Melo", 22);


p1.Apresentar();


Curso html = new Curso();

html.Nome = "Curso de HTML Avançado";

html.Alunos = new List<Pessoa>();
html.AdicionarAluno(p);
html.AdicionarAluno(p1);
html.ListarAluno();
string nome = html.ToString();
Console.WriteLine(nome);

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
string letra = Console.ReadLine() ?? "";

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
calc.Potencia(3, 2);
calc.Raiz(25);
calc.Decremento(10);
calc.Incremento(10);
calc.TabuadaFor(27365);
calc.TabuadaWhile(19);
calc.evenOrOdd(20);


int[] inteiros = new int[3];

inteiros[0] = 72;
inteiros[1] = 32;
inteiros[2] = 939;

string[] names = ["Diego", "Milena", "Teste"];

bool[] mtz = new bool[] { true, false, false, true };


List<char> listaChar = new List<char>();

listaChar.Add('A');
listaChar.Add('B');
listaChar.Add('C');



foreach (int valor in inteiros)
{
    Console.WriteLine(valor);
}

foreach (string nome in names)
{
    Console.WriteLine(nome);
}
foreach (char caractere in listaChar)
{
    Console.WriteLine(caractere);
}

