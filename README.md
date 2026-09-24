# WinFormMVC

Aplicação desktop desenvolvida em **C# com Windows Forms**, utilizando o padrão arquitetural **MVC (Model-View-Controller)**.

O projeto foi desenvolvido como exercício prático de estudo baseado nas **páginas 71 a 83** do livro **_Programação Back End II_**, de **Pedro Henrique Chagas Freitas, Maurício de Oliveira Saraiva e Cleverson Lopes Ledur**, publicado pelo **Grupo A — Selo SAGAH**.

A implementação reproduz os principais conceitos e a estrutura MVC apresentados no material, com adaptações necessárias para funcionamento nas versões atuais do **Visual Studio, .NET e Windows Forms**.

## 📚 Objetivo

O objetivo deste projeto é compreender, na prática, a separação de responsabilidades proporcionada pelo padrão **MVC**.

A aplicação realiza o gerenciamento de funcionários e separa sua estrutura em:

- **Model** — representa os dados e regras relacionadas ao funcionário.
- **View** — representa a interface gráfica construída com Windows Forms.
- **Controller** — realiza a comunicação entre a View e o Model.
- **Application** — inicializa e conecta os componentes da aplicação.

---

## 🏗️ Arquitetura MVC

O projeto segue o seguinte fluxo:

```text
                   UseMVCApplication
                          │
                    cria e conecta
                          │
             ┌────────────┼────────────┐
             ▼            ▼            ▼
          MODEL       CONTROLLER      VIEW
             │            │            │
       Funcionario   Funcionarios   Funcionarios
                      Controller       View
             │            │            │
             └────────────┼────────────┘
                          │
                    Aplicação MVC
```

### Model

O projeto `MVC-Model` contém a classe:

```text
Funcionario.cs
```

Ela representa um funcionário e armazena informações como:

- ID
- Nome
- Sobrenome
- Departamento
- Sexo

---

### Controller

O projeto `MVC-Controller` contém:

```text
FuncionariosController.cs
IUsersView.cs
```

O `FuncionariosController` realiza a comunicação entre o Model e a View.

Entre suas responsabilidades estão:

- carregar funcionários;
- selecionar funcionários;
- cadastrar novos funcionários;
- atualizar funcionários;
- remover funcionários;
- sincronizar os dados exibidos pela View.

A interface `IUsersView` define o contrato utilizado para comunicação entre o Controller e a interface gráfica.

---

### View

O projeto `MVC-View` contém a interface gráfica da aplicação:

```text
FuncionariosView.cs
FuncionariosView.Designer.cs
FuncionariosView.resx
```

A View foi construída utilizando **Windows Forms** e permite ao usuário visualizar e manipular os funcionários cadastrados.

---

### Application

O projeto:

```text
UseMVCApplication
```

é responsável pela inicialização da aplicação.

Ele cria os objetos necessários, conecta a View ao Controller e fornece os dados utilizados pelo Model antes de iniciar o Windows Forms.

---

## 📁 Estrutura da solução

```text
WinFormMVC
│
├── MVC-Model
│   └── Funcionario.cs
│
├── MVC-Controller
│   ├── FuncionariosController.cs
│   └── IUsersView.cs
│
├── MVC-View
│   ├── FuncionariosView.cs
│   ├── FuncionariosView.Designer.cs
│   └── FuncionariosView.resx
│
└── UseMVCApplication
    └── Program.cs
```

---

## ⚙️ Funcionalidades

A aplicação permite:

- visualizar funcionários cadastrados;
- selecionar um funcionário;
- visualizar seus dados;
- cadastrar um novo funcionário;
- editar informações;
- remover funcionários;
- atualizar a listagem automaticamente.

---

## 🖥️ Interface

A aplicação possui uma interface Windows Forms para gerenciamento dos funcionários.

Os dados apresentados incluem:

| Campo | Descrição |
|---|---|
| ID | Identificador do funcionário |
| Nome | Nome do funcionário |
| Sobrenome | Sobrenome do funcionário |
| Departamento | Departamento de atuação |
| Sexo | Sexo informado no cadastro |

A listagem é apresentada através de um `ListView`.

---

## 🛠️ Tecnologias utilizadas

- C#
- .NET
- Windows Forms
- Visual Studio
- Git
- GitHub
- Arquitetura MVC

---

## 🧠 Conceitos praticados

Durante o desenvolvimento foram trabalhados conceitos como:

- Model-View-Controller (MVC);
- separação de responsabilidades;
- interfaces em C#;
- orientação a objetos;
- propriedades;
- enumerações;
- coleções;
- eventos do Windows Forms;
- manipulação de `ListView`;
- comunicação entre projetos;
- referências entre assemblies;
- controle de versão com Git;
- publicação de projetos no GitHub.

---

## 🔧 Adaptações realizadas

O exemplo utilizado como referência foi desenvolvido em um contexto diferente das versões atuais do .NET e do Windows Forms.

Por isso, algumas adaptações foram necessárias durante a implementação.

Entre elas:

- adequação do projeto ao Windows Forms atual;
- ajustes relacionados ao WinForms Designer;
- tratamento de propriedades expostas pela View;
- organização das referências entre os projetos;
- correção de conflitos entre nomes de propriedades e componentes;
- prevenção de recursão de eventos durante a seleção de funcionários.

Um dos problemas encontrados durante os testes foi um `StackOverflowException` provocado pelo ciclo:

```text
SelectedIndexChanged
        ↓
SelectedUserChanged()
        ↓
SetSelectedUserInGrid()
        ↓
SelectedIndexChanged
        ↓
...
```

A implementação foi ajustada para impedir que uma seleção já existente fosse disparada novamente de maneira recursiva.

---

## ▶️ Como executar

1. Clone este repositório:

```bash
git clone https://github.com/joyalecosta/WinFormMVC.git
```

2. Abra a solução no **Visual Studio**.

3. Defina:

```text
UseMVCApplication
```

como **Startup Project**.

4. Compile a solução.

5. Execute utilizando:

```text
F5
```
## 📖 Referência

Este projeto foi desenvolvido para fins educacionais com base no conteúdo sobre **MVC (Model-View-Controller)** apresentado nas **páginas 71 a 83** da seguinte obra:

**FREITAS, Pedro Henrique Chagas; SARAIVA, Maurício de Oliveira; LEDUR, Cleverson Lopes. _Programação Back End II_. Grupo A, Selo SAGAH.**

### Conteúdo utilizado

O desenvolvimento deste projeto teve como referência o conteúdo apresentado nas páginas **71–83**, dedicado à organização e implementação da arquitetura **MVC**.

A estrutura proposta no material divide a aplicação em:

- **Model** — representação e manipulação dos dados;
- **View** — interface responsável pela interação com o usuário;
- **Controller** — camada responsável pela comunicação e controle entre Model e View.

A implementação deste repositório acompanha essa proposta e inclui adaptações necessárias para execução em versões atuais do **C#, .NET, Windows Forms e Visual Studio**.

> Este repositório possui finalidade exclusivamente educacional e documenta a implementação prática realizada durante o estudo do conteúdo de MVC apresentado na obra.
---

## 👨‍💻 Autor

**Joyce Costa**

Projeto desenvolvido para estudo de **C#, Windows Forms e arquitetura MVC**.
