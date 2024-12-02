# Desafio DesafioBookStore-Back

## Descrição do Projeto

O projeto **Desafio DesafioBookStore-Back** é uma API backend desenvolvida em .NET 8 com C# para gerenciar o registro de livros. A aplicação permite registrar livros, assuntos, autores. O projeto foi desenvolvido seguindo as melhores práticas de arquitetura de software e padrões de design, como Domain-Driven Design (DDD), além de integrar logs utilizando Serilog e tratamento de erros.

## Requisitos Atendidos

- **Cadastro de Livros**: Permite a criação, leitura, atualização e exclusão de livros.
- **Cadastro de Assuntos**: Permite a criação, leitura, atualização e exclusão de assuntos dos livros.
- **Gestão de Autores**: Permite a criação, leitura, atualização e exclusão de autores dos livros.
- **Validações**: Algumas validações simplres de quantidade máxima de caracteres em alguns campos.
- **Persistência de Dados**: Integração com PostgreSQL para dados transacionais.
- **Logs e Tratamento de Erros**: Implementação de logs estruturados e tratamento de erros com Serilog.

## Diferenciais Implementados

- **Arquitetura DDD (Domain-Driven Design)**: O projeto foi estruturado em camadas conforme os princípios de DDD, com separação clara entre Domain, Application, Infrastructure, IoC e Presentation.
- **Docker e Docker Compose**: Configurações completas para containerização da aplicação e seus serviços dependentes (PostgreSQL, API).
- **Testes Automatizados**: Implementação de testes unitários e de integração utilizando xUnit e FluentAssertions, garantindo a confiabilidade das funcionalidades.
- **Clean Code**: Código desenvolvido seguindo os princípios de Clean Code, com nomes de variáveis e métodos claros, e tratamento de exceções consistente.
- **Documentação com Swagger**: A API foi documentada utilizando Swagger, facilitando a exploração dos endpoints.

## Como Executar a Aplicação

### Pré-requisitos

- Docker
- Docker Compose

### Passos para Executar

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/seu-usuario/DesafioBookStore-Back.git
   cd DesafioBookStore-Back

2. **Configure as variáveis de ambiente (opcional)**:

- As variáveis de ambiente para a conexão com o PostgreSQL estão configuradas no arquivo docker-compose.yml.
- Se necessário, você pode modificar as variáveis no arquivo ou criar um arquivo .env.

3. **Execute o Docker Compose**:
   ```bash
   docker-compose up -d

4. **Executar as migrações**:
   ```bash
   dotnet ef database update --project "src/DesafioBookStore-Back.Infrastructure" --startup-project "src/DesafioBookStore-Back.Presentation"

4. **Acesse a aplicação**:
- A API estará disponível em http://localhost:8080.
- A documentação do Swagger estará disponível em http://localhost:8080/swagger.

## Executando os Testes

1. **Teste Unitários**:

- Os testes unitários cobrem as lógicas de negócio do projeto. Para executá-los, utilize o comando:
   ```bash
   dotnet test tests/DesafioBookStore-Back.UnitTests

2. **Testes de Integração**:
- Os testes de integração validam a comunicação com o banco de dados e a integração dos repositórios e serviços. Para executá-los, utilize o comando:
   ```bash
   dotnet test tests/DesafioBookStore-Back.IntegrationTests

## Estrutura do Projeto
- **DesafioBookStore-Back.Presentation**: Camada de apresentação, expõe os endpoints da API.
- **DesafioBookStore-Back.Application**: Camada de aplicação, responsável pela coordenação entre as camadas de apresentação e domínio.
- **DesafioBookStore-Back.Domain**: Camada de domínio, contém as entidades, regras de negócio e interfaces de repositório.
- **DesafioBookStore-Back.Infrastructure**: Camada de infraestrutura, implementa os repositórios, integra com bancos de dados e serviços externos.
- **DesafioBookStore-Back.UnitTests**: Projeto de testes unitários.
- **DesafioBookStore-Back.IntegrationTests**: Projeto de testes de integração.

## Considerações Finais
Este projeto foi desenvolvido com foco em qualidade de código, arquitetura bem definida e testes automatizados. Ele serve como um exemplo robusto de como criar uma aplicação .NET escalável, testável e de fácil manutenção.

Se você tiver alguma dúvida ou sugestão, sinta-se à vontade para abrir uma issue ou pull request no repositório!

Autor: Fernando de Souza Ferreira
Licença: MIT