# Aula 08: Registros (Structs)

---

# 👩🏻‍💻Exercícios propostos

## Exercício 1 - Nível Iniciante (Opcional)

Crie um programa que permita ao usuário cadastrar notas de alunos em uma lista. O programa deve:
- Solicitar ao usuário 5 notas.
-  Armazenar as notas em uma lista.
-  Exibir:
> - Todas as notas cadastradas;
> - A maior nota;
> - A menor nota;
> - A média das notas.

## Exercício 2 - Nível Intermediário

Defina uma struct Produto que contenha os seguintes campos: Nome, Codigo, Preco e Quantidade. Crie um programa que permita ao usuário inserir dados de 3 produtos e, em seguida, exiba 
o valor total em estoque (considerando o preço e a quantidade de cada produto).

## Exercício 3 - Nível Intermediário

Defina uma struct Livro com os seguintes campos: Titulo, Autor, AnoPublicacao, NumeroPaginas e Preco. Crie um programa que permita ao usuário inserir dados de 3 livros e, em seguida, 
calcule e exiba o preço total dos livros cadastrados e a média de páginas dos livros. 

## Exercício 4 - Nível Avançado (Retomada)

Desenvolva um programa em C# que simule um sistema de seleção de heróis da Marvel para uma equipe. O programa deve ter as seguintes funcionalidades:

### a) Cadastro de Heróis:
Crie uma função chamada cadastrarHeroi que permita ao usuário 
inserir o nome, poder e pontuação de um herói da Marvel. A função deve 
solicitar essas informações ao usuário e armazená-las em UM STRUCT. O 
programa deve permitir o cadastro de até 5 heróis.
### b) Seleção de Equipe:
Crie uma função chamada selecionarEquipe que permita ao usuário 
selecionar heróis para formar sua equipe. A função deve exibir os heróis 
cadastrados e permitir que o usuário selecione quais heróis deseja incluir 
em sua equipe. O usuário deve ser capaz de selecionar três heróis para 
sua equipe.
### c) Pontuação Total da Equipe:
Crie uma função chamada calcularPontuacaoTotal que calcule a 
pontuação total da equipe com base nos heróis selecionados. A 
pontuação total da equipe deve ser a soma das pontuações individuais de 
cada herói selecionado.
### d) Exibição da Equipe:
Crie uma função chamada exibirEquipe que exiba os heróis 
selecionados para a equipe, seu poder e a pontuação total da equipe.
### e) Menu:
Crie uma função chamada menuPrincipal que exiba um menu com as 
opções disponíveis para o usuário (cadastro de heróis, seleção de equipe, 
exibição da equipe e sair do programa). O usuário deve poder escolher 
uma das opções do menu e o programa deve executar a funcionalidade 
correspondente.

> #### *Requisitos Adicionais:*
>  - O programa deve continuar em execução até que o usuário escolha a opção de sair.
>  - Utilize STRUCTS para armazenar as informações dos heróis e da equipe.
>  - Não utilize classes ou listas! Pode (ou será que deve) utilizar vetores. 

## Exercício 5 - Nível Avançado (Opcional)
Uma empresa deseja controlar os chamados abertos pelos funcionários. Crie uma struct chamada Chamado contendo: Numero, Solicitante, Setor, Prioridade (1 a 3), Status e 
Descrição. O programa deve possuir as seguintes funções:

> cadastrarChamado(): Permite cadastrar até 10 chamados. Ao cadastrar, o status inicial deve ser: Aberto
> listarChamados(): Exibe todos os chamados cadastrados. 
> atualizarStatus(): Solicita o número do chamado e permite alterar o status para: Em andamento, Resolvido, Cancelado
> classificarPrioridade() Recebe a prioridade e retorna: 1 = Baixa, 2 = Média, 3 = Alta
> estatisticas() Exibe Quantos chamados estão abertos; Quantos estão em andamento; Quantos foram resolvidos; Quantos foram cancelados.

---

### ✔️ Exercícios concluidos:

- [] Exercício 1
- [] Exercício 2
- [] Exercício 3
- [] Exercício 4
- [] Exercício 5
