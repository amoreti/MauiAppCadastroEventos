📅 Cadastro de Eventos - .NET MAUI
Aplicativo desenvolvido em .NET MAUI para cadastro e gerenciamento básico de eventos. O sistema permite registrar informações do evento, realizar validações de datas, calcular automaticamente a duração do evento e o custo total, além de exibir um resumo completo em uma segunda tela.

🚀 Funcionalidades
> Cadastro de eventos com:
  - Nome do evento
  - Data de início
  - Data de término
  - Número de participantes
  - Local do evento
  - Custo por participante

> Validações:
  - Nome do evento obrigatório
  - Número de participantes válido
  - Custo por participante válido
  - Data de término não pode ser anterior à data de início

> Cálculos automáticos:
  - Duração do evento em dias utilizando DateTime e TimeSpan
  - Custo total do evento

> Navegação entre páginas

> Exibição do resumo do evento após o cadastro

> Utilização de BindingContext para associação dos dados entre a Model e a View


📁 Estrutura do Projeto
MauiAppCadastroEventos
│
├── Model
│   └── Evento.cs
│
├── View
│   ├── CadastroEventoPage.xaml
│   ├── CadastroEventoPage.xaml.cs
│   ├── EventoCadastrado.xaml
│   └── EventoCadastrado.xaml.cs
│
├── App.xaml
├── App.xaml.cs
└── MauiProgram.cs

📌 Requisitos Atendidos
✅ Utilização de BindingContext
Os dados cadastrados são enviados para a página de resumo através de um objeto da classe Evento e associados à interface por meio do BindingContext.

✅ Utilização de DateTime e TimeSpan
As datas do evento são armazenadas utilizando DateTime, enquanto a duração é calculada através da diferença entre as datas usando TimeSpan.

Exemplo:

public TimeSpan DuracaoEvento
{
    get
    {
        return DataTermino - DataInicio;
    }
}


✅ Cálculos automáticos
O sistema calcula automaticamente:

Duração do evento
Custo total do evento
public decimal CustoTotal
{
    get
    {
        return NumeroParticipantes * CustoPorParticipante;
    }
}


📷 Fluxo da Aplicação
Tela de Cadastro
> O usuário informa:
  - Nome do evento
  - Data de início
  - Data de término
  - Quantidade de participantes
  - Local
  - Custo por participante
Ao clicar em Cadastrar Evento, os dados são validados.

Tela de Resumo
Após o cadastro, o usuário é direcionado para uma nova página contendo:
  - Nome do evento
  - Data de início
  - Data de término
  - Duração
  - Quantidade de participantes
  - Local do evento
  - Custo por participante
  - Custo total do evento
Também é disponibilizado um botão para retornar à tela inicial.

🎥 Vídeo da explicação do código e da execução do aplicativo: https://youtu.be/d6fV-Hx8fT4
