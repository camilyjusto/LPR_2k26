# Aula 09: POO<br>(Programação Orientada a Objetos)

---

# 👩🏻‍💻Exercícios propostos

## Exercício 1 - Nível Iniciante (Opcional)

Fazer um programa para ler os valores da largura e altura de um retângulo. 
Em seguida, mostrar na tela o valor de sua área e perímetro.<br>
Usar a seguinte classe:

<table border="1">
  <tr>
    <th>Retangulo</th>
  </tr>
  <tr>
    <td>double Altura<br>double Largura</td>
  </tr>
  <tr>
    <td>calcArea()<br>calcPerimetro()</td>
  </tr>
</table>

## Exercício 2 - Nível Intermediário

Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). <br>
A classe funcionário deve conter os seguintes métodos:

- Mostrar os dados do funcionário (nome e salário líquido). 
> #### OBS: Tabela de Imposto
> - 10% para salários de até 2000
> - 15% para salários de até 3000
> - 20% para salários superiores a 3000

## Exercício 3 - Nível Intermediário

Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina. Cada objeto dessa classe deve guardar os seguintes dados do 
aluno: matrícula, nome, 2 notas de prova e 1 nota de trabalho. Escreva os seguintes métodos para esta classe:

- media: calcula a média final do aluno (cada prova tem peso 2,5 e o trabalho tem peso 2)
- final: calcula quanto o aluno precisa para a prova final (retorna zero se ele não for para a final). O aluno vai pra final se sua média for menor que 60.

## Exercício 4 - Nível Avançado (Opcional)

Desenvolva o diagrama de classes do seu jogo favorito: pense em personagens, cenários, coisas utilizadas pelos personagens, poderes, habilidades, etc… 
> - Dica: utilize um software de desenho. <br> Sugestão: LucidChart

O diagrama deve conter atributos, métodos, relacionamentos e cardinalidades.

Implemente 3 classes principais do seu jogo (as que você escolher) e submeta os códigos das classes no questionário

## Exercício 5 - Nível Iniciante (Opcional)
Um sistema de vendas precisa representar produtos e pedidos. Cada pedido está associado a um produto comprado.<br> Crie a classe Produto, com os atributos 
nome e preco. <br> Crie a classe Pedido, com um atributo que armazene um objeto da classe Produto e outro atributo chamado quantidade.

No método Main, crie um produto, associe-o a um pedido e exiba o nome do produto, a quantidade e o preço total da compra.

## Exercício 6 - Nível Intermediário

Implemente um sistema onde uma Reserva está associada a um Cliente, e um Cliente pode ter várias Reservas.

**a)** Crie as classes Cliente e Reserva. 

**b)** Um Cliente pode ter várias Reservas, mas cada Reserva pertence a apenas um Cliente.

**c)** Em Cliente, implemente um método para adicionar uma Reserva à lista de reservas do cliente. 

**d)** Em Reserva, adicione um atributo para referenciar o cliente que fez a reserva. 

**e)** Crie um método em Cliente que liste todas as reservas existentes para um determinado cliente.

## Exercício 7 - Nível Intermediário

Crie as classes “Livro” (atributos: Título, Autor e Ano de publicação) e “Biblioteca” (atributo: lista de objetos da classe Livro). <br>
Use métodos construtores, getters e setters quando necessário.Na classe Biblioteca:
- Crie os métodos “AdicionarLivro”
- Crie um método “ListarLivros”

Teste seu sistema no “Main”

## Exercício 8 - Avançado (Opcional)

Crie um sistema onde Aluno e Turma possuem uma relação N-N

**a)** Cada aluno pode estar matriculado em várias turmas, e cada turma pode ter vários alunos.

**b)** Crie as classes Aluno, Turma, e uma classe intermediária Matricula 

**c)** Em Aluno e Turma, crie listas de Matricula para associar um aluno a uma turma.

**d)** Implemente métodos em Aluno e Turma para adicionar uma nova Matricula.

**e)** Em Matricula, inclua um atributo para registrar a data da matrícula.

**f)** Adicione uma lógica para verificar se um Aluno já está matriculado em uma Turma antes de permitir uma nova Matricula.

**g)** Implemente um método em Turma para retornar a lista de todos os alunos matriculados.

---

### ✔️ Exercícios concluidos:

- [ ] Exercício 1
- [ ] Exercício 2
- [ ] Exercício 3
- [ ] Exercício 4
- [ ] Exercício 5
- [ ] Exercício 6
- [ ] Exercício 7
- [ ] Exercício 8

