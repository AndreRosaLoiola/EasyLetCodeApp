Two Sum Challenge — Console App em C#
Descrição
Este projeto é uma solução para o clássico problema "Two Sum", com a proposta de demonstrar habilidades de programação orientada a objetos, clareza na estrutura do código e boas práticas em C#, mesmo em um cenário simples.

O desafio consiste em:

Dado um array de inteiros e um valor alvo (target), encontrar os dois índices dos números no array cuja soma seja exatamente igual ao target.

Funcionalidades
Leitura de entrada do usuário via console (números e valor alvo).

Processamento e validação da entrada.

Execução do algoritmo com complexidade O(n) utilizando um dicionário (hash map).

Exibição clara do resultado ao usuário.

Arquitetura organizada com separação de responsabilidades.

TwoSumApp/
│
├── Program.cs           → Ponto de entrada da aplicação.
├── TwoSumSolver.cs      → Contém a lógica do algoritmo Two Sum.
├── UserInterface.cs     → Responsável por toda interação com o console.
└── README.md            → Este arquivo.


Como executar
Clone o repositório:


git clone https://github.com/seu-usuario/twosum-console-csharp.git
cd twosum-console-csharp


compile e execute com o .NET CLI:

dotnet build
dotnet run
