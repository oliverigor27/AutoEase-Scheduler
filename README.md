# Autoease Scheduler

<img align="center" src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white"> <img align="center" src="https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white"> <img align="center" src="https://img.shields.io/badge/Entity%20Framework-512BD4?style=for-the-badge&logo=entity-framework&logoColor=white"> <img align="center" src="https://img.shields.io/badge/PostgreSQL-316192?style=for-the-badge&logo=postgresql&logoColor=white"> <img align="center" src="https://img.shields.io/badge/MediatR-32CD32?style=for-the-badge&logo=mediatr&logoColor=white"> <img align="center" src="https://img.shields.io/badge/CQRS-FF4500?style=for-the-badge&logo=cqrs&logoColor=white"> <img align="center" src="https://img.shields.io/badge/SOLID%20Principles-FF7F50?style=for-the-badge&logo=solid&logoColor=white">

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
