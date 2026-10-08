StreamingFlix

Aplicação desenvolvida em C#/.NET 10 para representar regras de negócio de uma plataforma de streaming, com foco na implementação e validação de regras utilizando testes unitários parametrizados com xUnit.

📋 Sobre o projeto

O StreamingFlix possui regras relacionadas a:

Classificação de planos de acordo com a quantidade de telas simultâneas;
Cálculo da mensalidade com descontos conforme o período contratado;
Validação do acesso a conteúdo adulto considerando idade e controle parental.

O projeto também possui uma suíte de testes automatizados utilizando xUnit, [Theory] e [InlineData], permitindo validar diferentes cenários de uma mesma regra de negócio sem duplicação desnecessária de código.

🛠️ Tecnologias utilizadas
C#
.NET 10
xUnit
.NET CLI
Git e GitHub
📁 Estrutura do projeto
StreamingFlix/
│
├── StreamingFlix.App/
│   ├── PlanoStreamingService.cs
│   └── ...
│
├── StreamingFlix.Tests/
│   ├── PlanoStreamingServiceTests.cs
│   └── ...
│
├── StreamingFlix.sln
├── .gitignore
├── LICENSE
└── README.md
⚙️ Requisitos

Para executar o projeto, é necessário ter instalado:

.NET SDK 10.0 ou superior
Git

Para verificar a versão instalada do .NET:

dotnet --version
🚀 Como clonar o projeto

Clone este repositório utilizando:

git clone https://github.com/SEU-ClaudioCamylo/streaming-flix-xunit.git

Entre na pasta do projeto:

cd streaming-flix-xunit
▶️ Executando a aplicação

Para executar a aplicação:

dotnet run --project StreamingFlix.App
🧪 Executando os testes

Para executar todos os testes unitários:

dotnet test

O comando executa a suíte de testes do projeto e apresenta no terminal a quantidade de testes executados, aprovados e, caso existam, reprovados.

✅ Testes parametrizados

Os testes foram desenvolvidos utilizando [Theory] e [InlineData].

Essa abordagem permite executar o mesmo método de teste com diferentes conjuntos de dados.

Classificação de planos

Foram utilizados os seguintes cenários:

Telas simultâneas	Classificação
1	BÁSICO
2	PADRÃO
4	PREMIUM
Cálculo de desconto

Foram considerados diferentes períodos de contratação:

Valor base	Meses	Valor final
50	1	50
50	6	45
50	12	40
Validação de acesso a conteúdo adulto

Foram considerados os seguintes cenários:

Idade	Controle parental	Resultado
20	Não	true
20	Sim	false
16	Não	false
🎯 Cobertura dos testes

A suíte de testes verifica as principais regras implementadas no PlanoStreamingService.

Os testes parametrizados permitem validar múltiplos cenários para cada comportamento, incluindo:

Classificação dos planos;
Aplicação dos descontos;
Validação de idade;
Ativação do controle parental.

Cada conjunto de [InlineData] representa um cenário independente de teste. Dessa forma, é possível adicionar novos casos mantendo o código dos testes organizado e evitando a criação de vários métodos [Fact] praticamente iguais.

📌 Regras de negócio
Classificação do plano

O método ObterClassificacaoPorQualidade deve retornar:

BÁSICO → 1 tela;
PADRÃO → 2 telas;
PREMIUM → 4 ou mais telas.
Desconto da mensalidade

O método CalcularMensalidadeComDesconto aplica:

Sem desconto → contratos inferiores a 6 meses;
10% de desconto → contratos de 6 a 11 meses;
20% de desconto → contratos de 12 meses ou mais.
Acesso a conteúdo adulto

O método PodeAcessarConteudoAdulto retorna true somente quando:

A idade é igual ou superior a 18 anos; e
O controle parental está desativado.
👥 Contribuidores

Projeto desenvolvido como atividade acadêmica da disciplina de Gestão e Qualidade de Software.

Contribuidores:

Desenvolvedor 1 — Regras de Serviço / Backend
Desenvolvedor 2 — QA / Testes Unitários
Desenvolvedor 3 — Documentação / DevOps / Versionamento
📄 Licença

Este projeto está disponível sob a licença MIT.
