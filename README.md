# 🐺 WitcherCodex

## 📖 Sobre o Projeto

O **WitcherCodex** é uma aplicação desktop desenvolvida em **WPF (.NET 8)** inspirada no universo de *The Witcher*.
O objetivo do sistema é funcionar como um **codex interativo**, permitindo visualizar informações sobre:

* 🧟 Criaturas e monstros
* 🧪 Poções
* 🛢️ Óleos
* ✨ Sinais

A aplicação organiza e apresenta esses dados de forma visual, utilizando imagens e uma interface rica baseada em MVVM.

---

## 🏗️ Arquitetura do Projeto

O projeto segue uma separação em camadas, facilitando manutenção e escalabilidade:

```
WitcherCodex
│
├── WitcherCodex.Models       → Entidades e modelos de domínio
├── WitcherCodex.Repository   → Acesso a dados (Repository Pattern)
└── WitcherCodex.WPF          → Interface gráfica (WPF + MVVM)
```

---

## 📦 Tecnologias utilizadas

* **.NET 8**
* **WPF (Windows Presentation Foundation)**
* **Prism (MVVM + Injeção de Dependência)**

  * Prism.Core
  * Prism.Unity
  * Prism.Wpf

---

## 🧠 Padrões e Conceitos

O projeto utiliza boas práticas modernas:

* **MVVM (Model-View-ViewModel)**
* **Repository Pattern**
* **Injeção de Dependência (via Prism)**
* **Separação de responsabilidades (SRP)**

---

## 🖥️ Interface (WPF)

A aplicação desktop foi construída com:

* Estrutura baseada em **Views** e **ViewModels**
* Uso de **Resources** para gerenciamento de imagens
* Interface rica com elementos visuais do universo Witcher

### 🎨 Assets

O projeto contém diversos recursos visuais:

* Criaturas (ex: grifos, vampiros, lobisomens)
* Poções (ex: Andorinha, Gato, Trovão)
* Óleos (ex: Ogroide, Necrofago, Vampiro)
* Sinais (Aard, Igni, Quen, Axii, Yrden)

---

## ⚙️ Como Executar

### ✅ Pré-requisitos

* .NET 8 SDK
* Visual Studio 2022+

### ▶️ Passos

```bash
# Clonar o repositório
git clone https://github.com/seu-usuario/witcher-codex.git

# Abrir a solução
WitcherCodex.sln

# Definir o projeto WPF como Startup
WitcherCodex.WPF

# Executar
F5
```

---

## 📂 Estrutura dos Projetos

### 🔹 WitcherCodex.Models

Responsável por representar as entidades do sistema.

Exemplo:

```csharp
public class Criaturas_MonstrosEntity
{
    public TipoCriaturas_Monstros Tipo { get; private set; }

    public string Nome { get; private set; } = string.Empty;

    public string Descricao { get; private set; } = string.Empty;

    public List<string> Fraquezas { get; private set; }
}
```

### 🔹 WitcherCodex.Repository

Camada responsável pelo acesso e manipulação de dados.

* Implementação do padrão Repository
* Abstração da fonte de dados

### 🔹 WitcherCodex.WPF

Camada de apresentação.

* Views (XAML)
* ViewModels
* Navegação com Prism
* Injeção de dependência

---

## 🚀 Possíveis Melhorias

* 🔎 Sistema de busca e filtros
* 🗂️ Persistência em banco de dados (SQLite ou SQL Server)

---

## 📄 Licença

Este projeto é para fins educacionais e de estudo.

---

## 👨‍💻 Autor

Desenvolvido por **Raphael**

---

## ⚔️ Inspiração

Baseado no universo de *The Witcher*, criado por Andrzej Sapkowski e popularizado pelos jogos da CD Projekt Red.

---
