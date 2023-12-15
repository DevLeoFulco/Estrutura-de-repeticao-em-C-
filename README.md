# Estrutura de Repetição em C#

Este repositório contém um simples programa em C# utilizando a plataforma .NET que permite aos usuários agendar, consultar e desmarcar consultas para diferentes dias da semana. Este README fornecerá uma visão geral do código, explicará os conceitos de estruturas de repetição envolvidas e guiará os usuários sobre como utilizar o programa.

## Estruturas de Repetição

O programa faz uso de um **loop infinito** (`while (true)`) para garantir que o usuário possa interagir continuamente com as opções fornecidas. Dentro desse loop principal, encontramos a estrutura `switch` que é utilizada para lidar com diferentes opções escolhidas pelo usuário.

### Agendamento (`case 1`)

Ao selecionar a opção 1, o programa utiliza outro `switch` para lidar com os diferentes dias da semana (de 1 a 5, representando segunda a sexta-feira). O usuário é solicitado a escolher um dia e recebe uma mensagem correspondente ao dia escolhido. Se o usuário escolher a sexta-feira (5), o programa encerra.

### Consulta (`case 2`)

A opção 2 permite ao usuário obter informações sobre a disponibilidade para agendamento em diferentes dias da semana. Semelhante ao caso anterior, um `switch` é utilizado para apresentar mensagens específicas com base na escolha do dia.

### Cancelamento (`case 3`)

Na opção 3, o usuário pode cancelar uma consulta agendada. Novamente, um `switch` é utilizado para tratar diferentes dias da semana e apresentar mensagens apropriadas de cancelamento.

## Como Usar

1. Clone ou faça o download deste repositório.

```bash
git clone https://github.com/seu-usuario/nome-do-repositorio.git
```

2. Abra o projeto em seu ambiente de desenvolvimento preferido que suporte .NET, como Visual Studio ou Visual Studio Code.

3. Compile e execute o programa.

4. O programa exibirá um menu com as opções 1, 2 e 3. Escolha a opção desejada digitando o número correspondente e pressione Enter.

5. Siga as instruções adicionais para agendar, consultar ou cancelar consultas.

6. Repita o processo conforme necessário.

Sinta-se à vontade para explorar e adaptar o código conforme necessário.
