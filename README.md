# Autoease Scheduler

![.NET Core](https://img.shields.io/badge/.NET-8-blue)
![License](https://img.shields.io/badge/license-MIT-green)
![Build Status](https://img.shields.io/badge/build-passing-brightgreen)

**Autoease Scheduler** é uma aplicação backend desenvolvida para gerenciar e agendar reparos automotivos de forma eficiente. A aplicação fornece uma solução robusta para oficinas e empresas do setor automotivo que precisam organizar e otimizar seus serviços de manutenção e reparo.

## Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework**: ASP.NET 8
- **Banco de Dados**: PostgreSQL
- **ORM**: Entity Framework Core
- **Arquitetura**: N-Camadas, seguindo o padrão CQRS
- **Padrão de Design**: Mediator (implementado com o MediatR)
- **Princípios de Desenvolvimento**: SOLID, DRY

## Funcionalidades

- **Cadastro e Gerenciamento de Clientes**: Registre clientes e gerencie suas informações.
- **Agendamento de Reparos**: Programe e gerencie agendamentos para diversos tipos de serviços automotivos.
- **Gestão de Ordens de Serviço**: Controle as ordens de serviço, desde a criação até a finalização.
- **Integração com Banco de Dados**: Utilização do Entity Framework para acesso eficiente ao PostgreSQL.
- **Camadas e Separação de Responsabilidades**: Implementação de uma arquitetura bem definida para garantir manutenibilidade e escalabilidade.
- **Implementação de CQRS**: Separação clara de comandos e consultas para uma maior eficiência.
- **Padrão Mediator com MediatR**: Facilita a comunicação entre componentes, promovendo um design desacoplado.

## Arquitetura do Projeto

A aplicação segue uma arquitetura N-Camadas para uma melhor organização e separação de responsabilidades. As camadas incluem:

1. **Apresentação (API)**: Ponto de entrada para a aplicação, lidando com solicitações HTTP.
2. **Aplicação**: Contém a lógica de negócios e os comandos/consultas CQRS.
3. **Domínio**: Define as entidades de domínio e interfaces principais.
4. **Infraestrutura**: Implementa o acesso ao banco de dados e serviços externos.

## Configuração do Projeto

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/oliverigor27/AutoEase-Scheduler.git
   ```
   
2. **Configure o banco de dados PostgreSQL**:
   - Crie um banco de dados.
   - Atualize a string de conexão no arquivo de configuração `appsettings.json`.

3. **Execute as migrações**:
   ```bash
   dotnet ef database update
   ```

4. **Inicie a aplicação**:
   ```bash
   dotnet run
   ```

## Licença

Este projeto é licenciado sob a **MIT License**. Consulte o arquivo [LICENSE](LICENSE) para mais detalhes.
