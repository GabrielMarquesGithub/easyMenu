# [Cardápio Fácil](https://exemplo-app.com)

## Deploy

Você pode acessar a versão implantada deste projeto [aqui](https://exemplo-app.com).

## Imagens

![Imagem do banner para o template](./docs/Presentation.png)


## Pré-requisitos

Antes de começar, certifique-se de ter instalado o Git e o Docker em sua máquina.

## Passo a passo

1. Clone o repositório:

   ```bash
   git clone https://github.com/GabrielMarquesGithub/easyMenu
   ```

2. Navegue até a pasta da aplicação:

   ```bash
   cd easyMenu
   ```

3. Execute o container Docker utilizando os scripts de automação:

   ```bash
   bash ./scripts/docker.sh start
   ```


## Tecnologias Utilizadas

- Git
- Docker
- SQL Server

## API Externa

Este projeto consome uma API externa para obtenção de dados [API](https://exemplo-api.com)

## Padrões de Codificação

- **Nomenclatura:**

  - Interfaces: Seguem o padrão PascalCase com o sufixo "I".

- **Estrutura Principal de Arquivos:**
  - `app`: Contém o código-fonte da aplicação.
  - `configs`: Contém arquivos de configuração do ambiente.
  - `docs`: Contém arquivos necessários para a documentação do projeto.
  - `docker`: Contém os principais arquivos para a configuração e execução do Docker, como docker-compose.yml e Dockerfiles genéricos.
  - `scripts`: Contém scripts bash para automatizar tarefas comuns de desenvolvimento.
  - `sql`: Contém o essencial para a execução do banco de dados SQL.
  - `.editorconfig`: Arquivo de configuração do editor de código para manter a consistência entre os desenvolvedores.
  - `.gitignore`: Arquivo de configuração do Git para ignorar arquivos e pastas específicos.
  - `LICENSE`: Arquivo de licença do projeto.
  - `README.md`: Arquivo de documentação do projeto.

## Possíveis Atualizações

Entre as ideias de atualização para o projeto, estão:

- Ideia 1
- Ideia 2

## Observações

Este projeto é simplista visa apenas a demonstração de um template para ser empregado como base para outros projetos.

## Descrição	

Este é um template de projeto para ser utilizado como base para a criação de novos projetos. 

By: [Gabriel Marques](https://github.com/GabrielMarquesGithub)