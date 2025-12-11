List<string> menu = new List<string>();
List<int> price = new List<int>();
List<string> cars = new List<string>();


Console.WriteLine("Digite o preço inicial: ");
int initialPrice = Convert.ToInt32(Console.ReadLine());
price.Add(initialPrice);

Console.WriteLine("Digite o preço por hora: ");
int timePrice = Convert.ToInt32(Console.ReadLine());
price.Add(timePrice);


menu.Add("1 - Cadastrar Veiculo");
menu.Add("2 - Ver Veiculo");
menu.Add("3 - Remover Veiculo");
menu.Add("4 - Finalziar Programa");



int optMenu = 0;
do
{

    foreach (string opt in menu)
    {
        Console.WriteLine(opt);
    }
    optMenu = Convert.ToInt32(Console.ReadLine());


    switch (optMenu)
    {
        case 1:
            Console.WriteLine("Digite a placa do Veículo: ");
            string? placa = Console.ReadLine();
            if (!string.IsNullOrEmpty(placa))
            {
                cars.Add(placa);
                Console.WriteLine($"Veículo {placa} cadastrado com sucesso!");
            }
            break;
        case 2:
            Console.WriteLine("Os veículos estacionados são: ");
            if (cars.Count > 0)
            {
                foreach (string car in cars)
                {
                    Console.WriteLine($"- {car}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum veículo estacionado.");
            }
            break;
        case 3:
            Console.WriteLine("Digite a placa que deseja remover: ");
            string? placaSaida = Console.ReadLine();

            if (cars.Contains(placaSaida))
            {
                Console.WriteLine("Digite a Quantidade de horas que o veículo permaneceu: ");
                int time = Convert.ToInt32(Console.ReadLine());
                int finalPrice = time * price[1] + price[0];

                cars.Remove(placaSaida);

                Console.WriteLine($"Valor final: R$ {finalPrice:F2}");
                Console.WriteLine($"Veículo {placaSaida} removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado. Verifique se a placa está correta.");
            }
            break;
        case 4:
            Console.WriteLine("Encerrando programa");
            break;
        default:
            Console.WriteLine("Digite um valor válido");
            break;
    }

} while (optMenu != 4);

