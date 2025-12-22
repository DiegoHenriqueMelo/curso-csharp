<div align="center">

# 🚀 Curso C# & .NET

### Jornada de Aprendizado em C# e .NET

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Status](https://img.shields.io/badge/Status-Em%20Estudo-yellow?style=for-the-badge)
![Nível](https://img.shields.io/badge/Nível-Iniciante-green?style=for-the-badge)

</div>

---

## 📖 Sobre o Projeto

Este repositório documenta minha jornada de aprendizado em **C#** e **.NET**. Aqui você encontrará exemplos práticos, exercícios e projetos desenvolvidos durante meus estudos, desde os fundamentos até conceitos mais avançados.

> 💡 **Atualmente em nível iniciante**, explorando os fundamentos da linguagem e do ecossistema .NET.

---

## 📚 Estrutura do Repositório

```
📁 curso-csharp/
├── 📂 Exemplo Fundamentos/
│   ├── Exemplo Fundamentos.sln    # Solution do .NET
│   ├── 📂 ExemploFuncamentos.Commom/  # Biblioteca de classes comum
│   │   ├── Models/
│   │   │   ├── Pessoa.cs          # Classe modelo de pessoa
│   │   │   ├── Curso.cs           # Classe de curso com lista de alunos
│   │   │   └── Calculadora.cs     # Operações matemáticas
│   │   └── ExemploFuncamentos.Commom.csproj
│   └── 📂 ExemploFundamentos/         # Projeto principal
│       ├── Program.cs             # Exemplos práticos
│       ├── Arquivos/              # Manipulação de arquivos
│       │   └── arquivo.txt
│       └── Exemplo Fundamentos.csproj
├── 📂 Desafio Estacionamento/     # Sistema de estacionamento
│   ├── Program.cs             # Lógica do sistema
│   └── Desafio Estacionamento.csproj
├── 📂 Estrutura de Dados/         # Coleções avançadas
│   ├── Program.cs             # Queue, Stack, Dictionary
│   └── Estrutura de Dados.csproj
├── 📂 NuGet/                      # Pacotes NuGet e Serialização
│   ├── Program.cs             # Serialização JSON
│   ├── Models/
│   │   └── Venda.cs           # Modelo de dados
│   └── NuGet.csproj
├── 📂 POO/                        # Programação Orientada a Objetos
│   ├── Program.cs             # Exemplo de uso de POO
│   ├── Models/
│   │   ├── ContaCorrente.cs   # Sistema bancário com encapsulamento
│   │   ├── Pessoa.cs          # Classe base com virtual methods
│   │   ├── Aluno.cs           # Herda de Pessoa - polimorfismo
│   │   ├── Professor.cs       # Herda de Pessoa - polimorfismo
│   │   ├── Diretor.cs         # Exemplo de sealed class
│   │   ├── Conta.cs           # Classe abstrata - template para contas
│   │   ├── Corrente.cs        # Implementa Conta - classe concreta
│   │   └── Computador.cs      # Demonstração da classe Object
│   └── POO.csproj
└── README.md                  # Este arquivo
```

---

## 🗺️ Roadmap de Estudos .NET

### 📌 Fase 1: Fundamentos (Concluído)
- [x] Configuração do ambiente de desenvolvimento
- [x] Sintaxe básica do C#
- [x] Tipos de dados e variáveis
- [x] Operadores e expressões
- [x] Estruturas de controle (if, switch, loops)
- [x] Métodos e funções
- [x] Arrays e coleções básicas

### 📌 Fase 2: Programação Orientada a Objetos (Em Progresso)
- [x] Classes e objetos
- [x] Encapsulamento
- [x] Propriedades e indexadores
- [x] Construtores (padrão e parametrizados)
- [x] Validação de propriedades
- [x] Propriedades computadas
- [x] Relacionamentos entre classes
- [x] Modificadores de acesso (public, private)
- [x] Auto-propriedades
- [x] Backing fields
- [x] Métodos de instância
- [x] Proteção de dados sensíveis
- [x] Herança
- [x] Polimorfismo
- [x] Sobrescrita de métodos (override)
- [x] Métodos virtuais (virtual)
- [x] Classes abstratas
- [x] Métodos abstratos
- [x] Modificador protected
- [x] Classe Object
- [x] Sealed class
- [x] Interfaces

### 📌 Fase 3: Conceitos Intermediários (Em Progresso)
- [x] Tratamento de exceções
- [x] Coleções avançadas (List, Dictionary, Queue, Stack)
- [x] File I/O
- [x] Serialização (JSON)
- [x] Pacotes NuGet
- [ ] Delegates e eventos
- [ ] Expressões Lambda
- [ ] LINQ (Language Integrated Query)
- [ ] Generics

### 📌 Fase 4: .NET Core e Aplicações Modernas
- [ ] Introdução ao .NET Core/.NET 6+
- [ ] Entity Framework Core (ORM)
- [ ] Dependency Injection
- [ ] Async/Await e programação assíncrona
- [ ] APIs REST com ASP.NET Core
- [ ] Minimal APIs

### 📌 Fase 5: Banco de Dados
- [ ] SQL Server básico
- [ ] Conexão com banco de dados (ADO.NET)
- [ ] Entity Framework Core avançado
- [ ] Migrations e Code First
- [ ] Dapper (micro ORM)

### 📌 Fase 6: Desenvolvimento Web
- [ ] ASP.NET Core MVC
- [ ] Razor Pages
- [ ] Blazor (WebAssembly e Server)
- [ ] Authentication e Authorization
- [ ] Identity Framework

### 📌 Fase 7: Testes e Qualidade
- [ ] Unit Testing com xUnit/NUnit
- [ ] Mocking com Moq
- [ ] Test-Driven Development (TDD)
- [ ] Integration Tests

### 📌 Fase 8: Tópicos Avançados
- [ ] Design Patterns
- [ ] Clean Architecture
- [ ] CQRS e MediatR
- [ ] Microservices
- [ ] Docker e containerização
- [ ] CI/CD com GitHub Actions

---

## 🛠️ Tecnologias e Ferramentas

- **Linguagem:** C# 10+
- **Framework:** .NET 10.0
- **IDE:** Visual Studio Code / Visual Studio
- **Controle de Versão:** Git & GitHub

---

## 🚀 Como Executar os Projetos

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) instalado

### Executando um projeto

```bash
# Navegue até a pasta do projeto
cd "Exemplo Fundamentos"

# Execute o projeto
dotnet run
```

---

## 📝 Anotações e Recursos

### 🎯 Projetos no Repositório

#### Exemplo Fundamentos
Solução .NET organizada com múltiplos projetos:

**ExemploFuncamentos.Commom** (Biblioteca de Classes):
- **Classe Pessoa**: 
  - Construtores: padrão e parametrizado
  - Propriedades com backing fields privados (`_nome`, `_sobrenome`, `_idade`)
  - Validação com `throw new ArgumentException`
  - Propriedades computadas: `NomeCompleto` (concatenação)
  - Transformação de dados: `ToUpper()` em getters
  - Método `Apresentar()` usando propriedade computada
- **Classe Curso**:
  - Relacionamento de agregação com `List<Pessoa>`
  - Validação de propriedades
  - Métodos CRUD: `AdicionarAluno()`, `RemoverAluno()`, `ListarAluno()`
  - Método auxiliar: `ObertAlunos()` retorna contagem
  - Inicialização de coleções
- **Classe Calculadora**: 
  - Operações matemáticas (soma, subtração, multiplicação, divisão, módulo, potência, raiz)
  - Incremento e decremento (pré e pós)
  - Tabuada com loop `for` e `while`
  - Verificação de números pares/ímpares com `do-while`

**ExemploFundamentos** (Projeto Console):
- **File I/O**: 
  - Leitura de arquivos com `File.ReadAllLines()`
  - Tratamento de exceções com `try-catch-finally`
  - Manipulação de caminhos relativos
- **Arrays**: declaração, inicialização e acesso a elementos (`int[]`, `string[]`, `bool[]`)
- **List<T>**: coleções genéricas dinâmicas (`List<char>`)
- **Iteração**: loops `foreach` para percorrer arrays e listas
- Conversão de tipos: exemplos práticos de Parse e Convert
- Estruturas condicionais: if/else e switch/case
- Estruturas de repetição: for, while, do-while
- Operadores: lógicos e aritméticos
- Inicializador de objetos com propriedades `required`
- Operação nula segura (`??`) com `Console.ReadLine()`
- Utilização da biblioteca comum via referência de projeto

#### Desafio Estacionamento
Sistema de gerenciamento de estacionamento aplicando conceitos fundamentais:

**Funcionalidades:**
- 🅿️ Cadastro de veículos (placas)
- 👁️ Listagem de veículos estacionados
- 💰 Cálculo de preço baseado em tempo (taxa inicial + hora)
- ❌ Remoção de veículos com cobrança
- 🔄 Menu interativo com loop `do-while`

**Conceitos Aplicados:**
- `List<T>` para armazenar veículos, preços e menu
- Validação com `string.IsNullOrEmpty()` e `Contains()`
- Métodos de List: `Add()`, `Remove()`, `Count`
- `switch/case` para navegação no menu
- Formatação de moeda com `:F2`
- Entrada do usuário com `Console.ReadLine()`
- Lógica de negócio aplicada (cálculo de tarifas)

#### Estrutura de Dados
Exploração de estruturas de dados avançadas do .NET:

**Estruturas Implementadas:**
- 📊 **Queue<T>** (Fila): FIFO (First In, First Out)
  - `Enqueue()`: adiciona elemento no final
  - `Dequeue()`: remove elemento do início
- 📚 **Stack<T>** (Pilha): LIFO (Last In, First Out)
  - `Push()`: adiciona elemento no topo
  - `Pop()`: remove elemento do topo
- 🗂️ **Dictionary<TKey, TValue>**: pares chave-valor
  - `Add()`: adiciona par chave-valor
  - Acesso por chave eficiente
  - Iteração com `foreach` em `KeyValuePair`

**Conceitos Aplicados:**
- Tipos genéricos com diferentes tipos de dados
- Percurso de coleções com `foreach`
- Diferenças entre estruturas de dados
- Escolha adequada de estrutura por caso de uso

#### NuGet
Integração com pacotes externos e serialização de dados:

**Funcionalidades:**
- 📦 Instalação e uso de pacotes NuGet (Newtonsoft.Json)
- 🔄 Serialização de objetos para JSON
- 📝 Formatação de JSON com indentação
- 🏗️ Modelo de dados com validação

**Classe Venda:**
- Construtores: padrão e parametrizado
- Propriedades: `Id`, `Produto`, `Preco`
- Validação no setter de `Produto`
- Transformação com `ToUpper()`

**Conceitos Aplicados:**
- Gerenciamento de dependências com NuGet
- `JsonConvert.SerializeObject()` do Newtonsoft.Json
- `Formatting.Indented` para JSON formatado
- Serialização automática de propriedades
- Uso de bibliotecas de terceiros

#### POO (Programação Orientada a Objetos)
Aplicação prática de conceitos avançados de POO com exemplos do mundo real:

**Funcionalidades:**
- 👤 Sistema de cadastro de pessoas
- 🏦 Sistema bancário com conta corrente
- 💰 Operações bancárias (saque, consulta de saldo)
- 🔒 Encapsulamento completo de dados sensíveis
- 🎓 Hierarquia de classes (Pessoa → Aluno/Professor)
- 🔄 Polimorfismo com sobrescrita de métodos

**Classe Pessoa (Classe Base):**
- **Construtores**: padrão (sem parâmetros) e parametrizado (nome, idade)
- Propriedade `Nome` com validação no setter
- Backing field privado `_nome`
- Transformação automática para maiúsculas no getter
- Validação contra valores vazios
- Lançamento de `ArgumentException` para entradas inválidas
- Propriedade `Idade` com auto-implementação
- **Método virtual** `Apresentar()`: permite sobrescrita nas classes derivadas

**Classe Aluno (Herda de Pessoa):**
- **Herança**: `public class Aluno : Pessoa`
- **Construtor**: recebe nome, idade e nota, chama construtor base com `: base(nome, idade)`
- Propriedade `Nota` privada (encapsulamento)
- **Override do método `Apresentar()`**: comportamento específico para alunos
- Exibe nome e nota do aluno

**Classe Professor (Herda de Pessoa):**
- **Herança**: `public class Professor : Pessoa`
- **Construtor**: recebe nome, idade e salário, chama construtor base
- Propriedade `Salary` pública do tipo `float`
- **Override do método `Apresentar()`**: comportamento específico para professores
- Exibe nome e salário do professor
- **Sealed Class**: pode ser marcada como `sealed` para impedir herança

**Classe Diretor (Herda de Professor):**
- Demonstração de **sealed class**: erro proposital para mostrar restrição
- Comentado no código para exemplificar classes seladas
- Se Professor for `sealed`, Diretor não pode herdar

**Classe Conta (Classe Abstrata):**
- **Classe abstrata**: `public abstract class Conta` - não pode ser instanciada
- **Propriedade protected**: `Saldo` acessível apenas na classe e derivadas
- **Método concreto**: `ExibirSaldo()` implementado na classe base
- **Método abstrato**: `abstract void Creditar(decimal valor)` - obrigatório implementar
- Serve como template/contrato para classes derivadas

**Classe Corrente (Herda de Conta):**
- **Implementa classe abstrata**: `public class Corrente : Conta`
- **Override obrigatório**: implementa `Creditar()` da classe abstrata
- Propriedade `Tarifa` específica desta classe
- Acessa `Saldo` protegido da classe base
- Adiciona valor ao saldo sem regras extras

**Classe Computador:**
- Demonstração da classe `Object` (base de todas as classes em C#)
- Herança implícita: todas as classes herdam de `Object`
- Método `ToString()` herdado de Object

**Interface ICalculadora:**
- **Interface**: define um contrato com métodos sem implementação
- Métodos obrigatórios: `Somar`, `Subtrair`, `Multiplicar`, `Dividir`
- Não possui implementação de código, apenas assinaturas

**Classe Calculadora (Implementa ICalculadora):**
- **Implementação de Interface**: `public class Calculadora : ICalculadora`
- Obrigada a implementar todos os métodos definidos na interface
- Implementação concreta das operações matemáticas básicas

**Classe ContaCorrente:**
- **Construtor parametrizado**: inicialização obrigatória de conta e saldo
- **Propriedade pública**: `NumeroConta` (acesso externo permitido)
- **Propriedade privada**: `Saldo` (encapsulamento total)
- **Método `Sacar()`**: 
  - Validação de saldo suficiente
  - Decremento do saldo se válido
  - Feedback ao usuário sobre operação
- **Método `ExibirSaldo()`**: acesso controlado ao saldo privado
- Formatação monetária (`R$`)

**Conceitos Aplicados:**
- **Herança**: reutilização de código através de classes base
- **Polimorfismo**: métodos com comportamentos diferentes em cada classe derivada
- **Métodos virtuais**: palavra-chave `virtual` permite sobrescrita
- **Override**: palavra-chave `override` para sobrescrever métodos da classe base
- **Construtor base**: chamada com `: base()` para inicializar classe pai
- **Hierarquia de classes**: Pessoa como classe base, Aluno e Professor como derivadas
- **Classes abstratas**: `abstract class` - não podem ser instanciadas, servem como template
- **Métodos abstratos**: `abstract` - sem implementação, obrigatório implementar em derivadas
- **Modificador protected**: membros acessíveis na classe e nas derivadas
- **Sealed class**: `sealed` - impede que outras classes herdem dela
- **Classe Object**: todas as classes em C# herdam implicitamente de Object
- **Métodos de Object**: `ToString()`, `Equals()`, `GetHashCode()` disponíveis em todas as classes
- **Encapsulamento forte**: propriedades privadas com métodos públicos
- **Modificadores de acesso**: `public`, `private`
- **Construtores parametrizados**: inicialização de estado obrigatória
- **Validação de regras de negócio**: verificações antes de operações
- **Backing fields**: controle granular de getters/setters
- **Auto-propriedades**: simplificação quando não há lógica extra
- **Separação de responsabilidades**: classes focadas em domínios específicos
- **Proteção de dados sensíveis**: saldo bancário acessível apenas por métodos
- **Tipos decimais**: uso de `decimal` para valores monetários precisos
- **Tipos numéricos variados**: `double` para notas, `float` para salário

### Links Úteis
- [Documentação Oficial C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [Documentação .NET](https://docs.microsoft.com/pt-br/dotnet/)
- [Microsoft Learn](https://learn.microsoft.com/pt-br/dotnet/)
- [C# Corner](https://www.c-sharpcorner.com/)

### Conceitos Aprendidos

#### ✅ Fundamentos da Linguagem
- Criação de projetos console com .NET CLI
- Estrutura básica de um programa C#
- Namespaces e organização de código
- Instanciação de objetos
- Organização de solutions (.sln) com múltiplos projetos
- Bibliotecas de classes (Class Library)
- Referências entre projetos

#### ✅ Tipos de Dados
- Tipos primitivos: `int`, `string`, `char`, `bool`, `decimal`, `double`, `float`
- Tipos especiais: `byte`, `long`, `uint`, `short`, `ulong`
- Conversão entre tipos: `Parse()`, `Convert.ToInt32()`, `ToString()`

#### ✅ Operadores
- **Aritméticos**: `+`, `-`, `*`, `/`, `%`, `++`, `--`
- **Lógicos**: `||` (OR), `&&` (AND), `!` (NOT)
- **Comparação**: `>=`, `<=`, `==`, `!=`

#### ✅ Estruturas de Controle
- **Condicionais**: `if/else`, `switch/case`
- **Loops**: `for`, `while`, `do-while`
- **Iteração**: `foreach` para percorrer coleções
- Operadores de decisão
- Estruturas de repetição com condições

#### ✅ Arrays e Coleções
- Arrays tipados: `int[]`, `string[]`, `bool[]`
- Inicialização de arrays: `new int[3]`, `["item1", "item2"]`
- Acesso por índice
- `List<T>`: coleção genérica dinâmica
- Métodos de List: `Add()`, `Remove()`, `Contains()`, `Count`
- Validação de strings: `string.IsNullOrEmpty()`
- Iteração com `foreach`
- Operação nula segura: `??` (null coalescing)

#### ✅ Coleções Avançadas
- **Queue<T>** (Fila): estrutura FIFO
  - Métodos: `Enqueue()`, `Dequeue()`
- **Stack<T>** (Pilha): estrutura LIFO
  - Métodos: `Push()`, `Pop()`
- **Dictionary<TKey, TValue>**: mapeamento chave-valor
  - Método: `Add()`, acesso por chave
  - `KeyValuePair` em iterações
- Generics: `<T>` para tipos parametrizados
- Escolha de estrutura adequada ao problema

#### ✅ File I/O (Entrada/Saída de Arquivos)
- Leitura de arquivos: `File.ReadAllLines()`
- Caminhos relativos e absolutos
- Iteração sobre linhas de arquivo
- Tratamento de exceções em operações de arquivo
- Bloco `try-catch-finally` para garantir execução

#### ✅ Serialização e Pacotes NuGet
- **NuGet**: gerenciador de pacotes do .NET
- Instalação de pacotes: `dotnet add package`
- **Newtonsoft.Json**: biblioteca popular para JSON
- `JsonConvert.SerializeObject()`: conversão de objeto para JSON
- `Formatting.Indented`: formatação legível de JSON
- Serialização automática de propriedades públicas
- Integração com bibliotecas de terceiros
- Gerenciamento de dependências no `.csproj`

#### ✅ Programação Orientada a Objetos
- Criação de classes personalizadas (`Pessoa`, `Calculadora`, `Curso`, `ContaCorrente`)
- **Construtores**: padrão e parametrizado
- **Backing Fields**: campos privados (`_nome`, `_sobrenome`, `_idade`)
- Propriedades com `get` e `set` personalizados
- **Auto-propriedades**: implementação automática de getters/setters
- **Validação**: lançamento de exceções (`ArgumentException`)
- **Propriedades computadas**: somente leitura com expressão (`NomeCompleto`)
- **Transformação de dados**: `ToUpper()` em getters
- Métodos de instância
- **Encapsulamento forte**: propriedades privadas acessadas por métodos públicos
- **Modificadores de acesso**: `public`, `private`
- **Proteção de dados sensíveis**: encapsulamento de saldo bancário
- **Relacionamentos**: agregação (Curso tem lista de Pessoas)
- **Coleções em classes**: `List<Pessoa>` como propriedade
- Organização de código em bibliotecas reutilizáveis
- **Tipos monetários**: uso de `decimal` para precisão financeira
- **Regras de negócio**: validação de operações (saque com saldo suficiente)
- **Herança**: criação de hierarquias de classes com reutilização de código
- **Polimorfismo**: comportamentos diferentes para o mesmo método em classes derivadas
- **Métodos virtuais**: uso de `virtual` para permitir sobrescrita
- **Override de métodos**: sobrescrita com `override` em classes derivadas
- **Construtor base**: inicialização da classe pai com `: base()`
- **Hierarquia de tipos**: Aluno e Professor herdam de Pessoa
- **Classes abstratas**: `abstract class` - templates que não podem ser instanciados
- **Métodos abstratos**: `abstract` - contratos sem implementação, obrigatórios nas derivadas
- **Modificador protected**: visibilidade restrita à classe e suas derivadas
- **Sealed class**: `sealed` - previne herança de uma classe
- **Classe Object**: base implícita de todas as classes em C#
- **Métodos de Object**: `ToString()`, `Equals()`, `GetHashCode()` herdados automaticamente
- **Interfaces**: contratos de implementação com métodos sem corpo

#### ✅ Tratamento de Exceções
- Lançamento de exceções: `throw new ArgumentException()`
- Captura de exceções: `try-catch-finally`
- Exceções genéricas: `Exception`
- Acesso a mensagens de erro: `ex.Message`
- Bloco `finally`: execução garantida
- Validação de entrada com mensagens descritivas
- Proteção de propriedades contra valores inválidos

#### ✅ Matemática em C#
- Uso da classe `Math`
- Operações: potência (`Math.Pow`), raiz quadrada (`Math.Sqrt`)
- Implementação de calculadora com operações básicas

---

## 📈 Progresso Atual

```
████████████████▓░░░ 83% Concluído
```

**Última atualização:** Dezembro 2025

**🏆 Projetos Práticos Concluídos:** 4
- ✅ Sistema de Estacionamento
- ✅ Estrutura de Dados (Queue, Stack, Dictionary)
- ✅ NuGet e Serialização JSON
- ✅ POO Completo - Herança, Polimorfismo, Classes Abstratas e Sealed

**Interfaces
- Delegates e eventos
- Expressões Lambda e LINQ

---

## 🎯 Objetivos

- [x] Dominar os fundamentos do C#
- [ ] Construir aplicações console robustas
- [ ] Desenvolver APIs REST
- [ ] Criar aplicações web com ASP.NET Core
- [ ] Implementar testes automatizados
- [ ] Contribuir para projetos open source

---

## 📬 Contato

Sinta-se à vontade para explorar o código e acompanhar meu progresso!

---

<div align="center">

**Feito com 💜 durante minha jornada de aprendizado**

⭐ Se este repositório te ajudou de alguma forma, considere dar uma estrela!

</div>