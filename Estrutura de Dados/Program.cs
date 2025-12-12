

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

Console.WriteLine("Percorrendo fila");

foreach (int i in fila)
{
    Console.WriteLine(i);
}

Console.WriteLine($"Removendo item da fila {fila.Dequeue()}");


foreach (int i in fila)
{
    Console.WriteLine(i);
}
Console.WriteLine("\n");

Stack<int> pilha = new Stack<int>();

pilha.Push(1);
pilha.Push(3);
pilha.Push(5);
pilha.Push(7);

Console.WriteLine("Percorrendo pilha");
foreach (int i in pilha)
{
    Console.WriteLine(i);
}

Console.WriteLine($"Removendo item da pilha {pilha.Pop()}");
foreach (int i in pilha)
{
    Console.WriteLine(i);
}
Console.WriteLine("\n");


Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("MG", "Minas Gerais");

foreach (var i in estados)
{
    Console.WriteLine(i);
}