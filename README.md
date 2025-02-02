# CarrosDesserializar

Este programa tem como objetivo **modelar a classe Carros** e **realizar a desserialização** dos dados obtidos a partir de um **endpoint específico**. A classe **Carros** reflete a estrutura dos dados retornados pelo endpoint, permitindo que você manipule e utilize essas informações em diferentes partes da aplicação.

### Objetivo

O principal objetivo deste projeto é **extrair dados de uma API**, representá-los de forma estruturada utilizando a classe **Carros**, e realizar a **desserialização** desses dados para que possam ser usados em operações dentro do código.

### Funcionalidades

- **Modelagem da Classe Carros**: A classe reflete a estrutura dos dados retornados do endpoint, com atributos que representam as informações do carro.
- **Desserialização de JSON**: Utiliza a biblioteca de **desserialização JSON** do C# para converter os dados recebidos de um formato JSON em objetos que podem ser manipulados facilmente.
- **Interação com a API**: O programa faz uma solicitação ao endpoint, recebe os dados em formato JSON e os desserializa para um formato mais acessível.

### Estrutura da Classe Carros

A classe **Carros** possui os seguintes atributos, representando as informações que são retornadas pelo endpoint:

- **Modelo**: O modelo do carro.
- **Marca**: A marca do carro.
- **Ano**: O ano de fabricação do carro.
- **Cor**: A cor do carro.

### Como Usar

1. **Clone o repositório** para o seu ambiente local:
   ```bash
   git clone https://github.com/Carlos4415/CarrosDesserializar.git
