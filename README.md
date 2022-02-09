# TechnicalChallange #

Aplicação do tipo console cujo objetivo é receber a entrada de um número e decompor o mesmo, achando seus divisores, incluindo os divisores primos  

## NumberDecomposition
Projeto class library que contém o serviço responsável pela tarefa de decompor um número informado e exibir seus divisores, incluindo os números primos

## TechnicalChallangeApp
Projeto do tipo console que interage com o usuário, solicitando ao mesmo a entrada de um valor inteiro que será passado para o serviço responsável pela decomposição.

## Instalando o projeto
Clone o repositório
```
git clone <url_repositorio>
```
Depois de clonar o repositório, acesse o diretório para onde o mesmo foi baixado e restaure as dependências do projeto.
```
dotnet restore
```
## Executando o projeto
Acesse o diretório src\TechnicalChallangeApp e execute o comando abaixo:
```
dotnet run
```
## Executando testes unitários
Para executar todos os testes existentes, acesse o diretório raiz e execute o comando abaixo:
```
dotnet test
```
## Compilando a aplicação
Para compilar as alterações ou novas implementações do projeto, acesse o diretório raiz e execute o comando abaixo:
```
dotnet build
```