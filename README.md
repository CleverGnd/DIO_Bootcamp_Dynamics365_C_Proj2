# Bootcamp Microsoft Dynamics 365 - Desafio de Projeto - GitHub
Este repositório foi criado para apresentação do Desafio de Projeto desenvolvido no Bootcamp Microsoft Dynamics 365 da DIO.

Unidade: Linguagens Para Dynamics: Domine o C# e Conheça o JavaScript <br>
Professor: [Leonardo Buta](https://github.com/leonardo-buta)

<a href="https://www.dio.me/bootcamp/bootcamp-microsoft-dynamics-365-brasil"><img src="https://hermes.dio.me/tracks/1b7d9511-9093-40b7-a710-45b46afa9d35.png" align="center" height="120" width="120" ></a> <a href="https://www.dio.me/"><img src="https://hermes.digitalinnovation.one/assets/diome/logo-full.svg" align="center" height="120" width="120" ></a> <br>

## Desafio de projeto
Este repositório foi criado para apresentação do Desafio de Projeto desenvolvido no Bootcamp Microsoft Dynamics 365 da DIO. O desafio consiste em construir um sistema de hospedagem para realizar uma reserva em um hotel usando os conhecimentos adquiridos no módulo "Linguagens Para Dynamics: Domine o C# e Conheça o JavaScript".

### Contexto
Você foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Para isso, deve-se utilizar a classe Pessoa, que representa o hóspede, a classe Suíte e a classe Reserva, que fará um relacionamento entre ambos.

O programa deverá calcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

![Diagrama de classe estacionamento](diagrama_classe_hotel.png)
### Solução proposta
Foi desenvolvida uma classe Reserva que representa uma reserva de hospedagem em uma suíte de hotel. Essa classe possui as seguintes propriedades:

    - Hospedes: Lista de objetos do tipo Pessoa que representam os hóspedes da reserva.
    - Suite: Objeto do tipo Suite que representa a suíte reservada.
    - DiasReservados: Número de dias reservados para a hospedagem.

A classe Reserva possui um construtor padrão e um construtor que recebe o número de dias reservados como parâmetro. Além disso, a classe possui os seguintes métodos:

    - CadastrarHospedes(List<Pessoa> hospedes): Método que recebe uma lista de objetos do tipo Pessoa e verifica se a capacidade da suíte é suficiente para a quantidade de hóspedes informada. Caso seja suficiente, a lista de hóspedes é armazenada na propriedade Hospedes. Caso contrário, é lançada uma exceção informando que a capacidade da suíte é menor que o número de hóspedes informado.
    - CadastrarSuite(Suite suite): Método que recebe um objeto do tipo Suite e armazena na propriedade Suite.
    - ObterQuantidadeHospedes(): Método que retorna a quantidade de hóspedes da reserva.
    - CalcularValorDiaria(): Método que calcula e retorna o valor total da diária da reserva, considerando o número de dias reservados e o valor da diária da suíte. Caso os dias reservados sejam maiores ou iguais a 10, é concedido um desconto de 10% no valor total da diária.

Dessa forma, a classe Reserva permite cadastrar os hóspedes da reserva, cadastrar a suíte reservada, obter a quantidade de hóspedes da reserva e calcular o valor total da diária. A solução proposta atende aos requisitos do desafio e permite a criação de objetos do tipo Reserva para representar as reservas de hospedagem em um hotel.

## Agradecimentos
Agradeço à DIO e a Microsoft por proporcionar este Bootcamp e a todos os professores e instrutores que contribuíram para o sucesso deste projeto.