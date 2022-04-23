# Sales Manager

[![NPM](https://img.shields.io/npm/l/sales?style=plastic)](https://github.com/Edsogarc/SalesManager/blob/main/LICENSE)

# Sobre o Projeto
Projeto MVC construído durante as aulas do professor [Nélio alves](https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/).
<p>O projeto realiza o gerenciamento de vendas por departamento e vendedor(a).</p>

<p>
  <a href="#modelo-conceitual">Modelo Conceitual</a> |
  <a href="#features">Features</a> |
  <a href="#rodando-a-aplicação">Rodando a aplicação</a> |
  <a href="#tecnologias">Tecnologias</a> |
  <a href="#autor">Autor</a>
</p>

## Layout
<!-- Department, Seller and Sales Record -->
<details>
  <summary><strong>Department, Seller and Sales Record</strong></summary>
  <img src="./SalesManager/wwwroot/images/gitHome.gif" alt="Home" />
  <img src="./SalesManager/wwwroot/images/Department.PNG" alt="Department" />
  <img src="./SalesManager/wwwroot/images/Seller1.PNG" alt="Seller" />
  <img src="./SalesManager/wwwroot/images/SellerCreate.PNG" alt="Create" />
  <img src="./SalesManager/wwwroot/images/SellerEdit.PNG" alt="Edit" />
  <img src="./SalesManager/wwwroot/images/SalesIdex.PNG" alt="Sales" />
  <img src="./SalesManager/wwwroot/images/SalesSimple.PNG" alt="Simple" />
  <img src="./SalesManager/wwwroot/images/SalesGrouping.PNG" alt="Grouping" />
</details>
  


## Modelo Conceitual
![modelo Conceitual](SalesManager/wwwroot/images/modeloConceitual.PNG)

## Features

- [x] Theme Superhero
- [x] CRUD para o Departamento
- [x] CRUD para o Vendedor(a)
- [x] Consulta de vendas simples e agrupada por departamentos e vendedor(a)
- [x] Tratamento de Exceções

## Tecnologias

#### Back-end
- C#
- Asp-net 6
- Entity Framework Core 6
- SQL Server 2019 developer

#### Front-end
- HTML / CSS / Javascript
- bootstrap 5
- jQuery

## Rodando a aplicação
Pré-requisitos: .NET 6 e SQL Server developer<br>
Obs: necessário mudar a ConnectionStrings no arquivo appsettings.json e colocar o nome do seu servidor. 

```powershell
# Clone este repositório
> git clone https://github.com/Edsogarc/SalesManager.git

# Acesse a pasta do projeto no terminal/cmd
> cd /SalesManager

# executar o projeto
> dotnet run
```

### Autor
Edson Garcia

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/edsongarciadesousa/)


