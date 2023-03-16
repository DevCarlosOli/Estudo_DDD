
<h1 align="center">
	<img src="https://seeklogo.com/images/C/c-sharp-c-logo-02F17714BA-seeklogo.com.png"  alt="Logo"  width="240"><br><br>
    API C# Utilizando Padrão de Modelagem DDD
</h1>

<div align="center">
    <a href="https://www.linkedin.com/in/carlos-r-de-oliveira-filho-62a996200/">
        <img src="https://img.shields.io/static/v1?label=Author&message=Carlos&color=162285&style=for-the-badge&logo=LinkedIn" alt="Author: Carlos">
    </a>
  <br>
    <a href="#">
		<img  src="https://img.shields.io/static/v1?label=Language&message=CSharp&color=purple&style=for-the-badge&logo=CSharp"  alt="Language: CSharp">
	</a>
	<a href="#">
		<img src="https://img.shields.io/static/v1?label=Framework&message=DotNet6&color=bf53b1&style=for-the-badge&logo=DotNet"  alt="Language: Dot Net 6">
	</a>
    </p>
</div>

## Table of Contents

<p align="center">
 <a href="#about">About</a> •
 <a href="#features">Features</a> •
 <a href="#revised-concepts">Revised Concepts</a> • 
 <a href="#installation">Installation</a> • 
 <a href="#getting-started">Get Started</a> • 
 <a href="#technologies">Technologies</a> • 
 <a href="#license">License</a>
</p>

## 📌About

<div>
    <p align="center">
    <em>
        Desenvolvimento de uma API simples com foco nos estudos nos padrões de modelagem de software DDD e Solid utilizando como linguagem para 
        desenvolvimento o C# (CSharp), para framework foi utilizado Dot Net 6, além das tecnologias JWT para autenticação e troca de informações,
        Identity para controle de usuários, AutoMapper para mapeamentos de objetos, para testes foi utilizado o padrão TDD, Sql Server para base de dados.
    </em>
    </p>
</div>

## 🚀Features

- Criação de usuários;
- Criação, Edição, Deleção de mensagens;
- Recebimento de lista de mensagens.

## 👓Revised Concepts

- Swagger para verificação de rotas
- Uso de Rotas
- API
- CRUD Básico
- Controle e Autenticação de Usuários

## 📕Installation

**Você precisa ter instalado na máquina**
- [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/downloads/)
- [Node.js](https://nodejs.org/en/)
- [Npm](https://www.npmjs.com/) or [Yarn](https://yarnpkg.com/)
- [DotNet SDK 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [SQLServer](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)

**Recomendações**
-   É recomendado que você tenha na sua máquina o Visual Studio 2022 instalado
-   Para base de dados utilize o SQL Server da versão 18 para cima
-   Para testes da API recomendo utilizar o PostMan, você pode utilizar ele pelo navegador google ou utilizar ele de forma local, 
para isso basta baixar em sua máquina clicando [aqui](https://www.postman.com/downloads/).

**Vamos dividir em 3 passos**
1. Clone este repositório
2. Instale as dependências
3. Inicialize o BackEnd
  ---
### 1. Clone este repositório
```
git clone https://github.com/DevCarlosOli/Estudo_DDD.git
```
---
### 2. Instale as dependências
```
npm install
```
or
```
yarn
```

*Certifique-se de que sua internet esteja estável, pois isso pode demorar um pouco* 

### 3. Inicialize o BackEnd

Se você tem um ***BackEnd local***, inicie ele antes deste projeto

Se você tem um ***Hosted BackEnd***, você vai precisar configurar as Rotas e Modelos deste projeto com seu BackEnd

## 🎮Getting Started

1. Execute o back-end ou configure conforme explicado acima 

2. Execute o projeto
Para executar o projeto, com o Visual Studio aberto é necessário ir na pasta Apis, clicar com botão direito no projeto WebAPIs e clicar na opção Definir Como Projeto
de Inicialização e depois inicializar o projeto.
Para executar o projeto de teste abra um novo Visual Studio e altere o projeto de inicialização, conforme explicado acima e inicie o projeto de testes.

3. Basta esperar que seu navegador irá abrir o projeto local. Para o projeto de testes uma nova janela local irá abrir.

## 🌐Technologies

**Pacotes Utilizados**
- Microsoft.Extensions.Identity.Stores  === IdentityUser
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.AspNetCore.Identity.EntityFrameworkCore

**API**
- Microsoft.AspNetCore.Identity.UI
- Microsoft.AspNetCore.Authentication.JwtBearer
- Install-Package Microsoft.EntityFrameworkCore.Tools
- Install-Package Microsoft.EntityFrameworkCore.Design
- AUTOMapper
