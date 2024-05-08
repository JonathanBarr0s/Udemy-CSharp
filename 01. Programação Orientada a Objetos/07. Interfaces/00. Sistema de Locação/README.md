# Exercício - Sistema de Locação

Uma locadora brasileira de carros cobra um valor por hora para locações de até 12 horas. Porém, se a duração da locação ultrapassar 12 horas, a locação será cobrada com base em um valor diário. Além do valor da locação, é acrescido no preço o valor do imposto conforme regras do país que, no caso do Brasil, é 20% para valores até 100.00, ou 15% para valores acima de 100.00. Fazer um programa que lê os dados da locação (modelo do carro, instante inicial e final da locação), bem como o valor por hora e o valor diário de locação. O programa deve então gerar a nota de pagamento (contendo valor da locação, valor do imposto e valor total do pagamento) e informar os dados na tela. Veja os
exemplos.

### Exemplo de Entrada:

```
Enter rental data
Car model: Civic
Pickup (dd/MM/yyyy hh:mm): 25/06/2018 10:30
Return (dd/MM/yyyy hh:mm): 25/06/2018 14:40
Enter price per hour: 10.00
Enter price per day: 130.00
```

### Exemplo de Saída:

```
INVOICE:
Basic payment: 50.00
Tax: 10.00
Total payment: 60.00
```

### Exemplo de Entrada:

```
Enter rental data
Car model: Civic
Pickup (dd/MM/yyyy hh:mm): 25/06/2018 10:30
Return (dd/MM/yyyy hh:mm): 27/06/2018 11:40
Enter price per hour: 10.00
Enter price per day: 130.00
```

### Exemplo de Saída:

```
INVOICE:
Basic payment: 390.00
Tax: 58.50
Total payment: 448.50
```

---

Minha resposta:

- [Program](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/06.%20Trabalhando%20com%20Arquivos/00.%20Processando%20Arquivos/ProcessandoArquivos/ProcessandoArquivos/Program.cs)

**Entities**
- [Estoque](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/06.%20Trabalhando%20com%20Arquivos/00.%20Processando%20Arquivos/ProcessandoArquivos/ProcessandoArquivos/Entities/Estoque.cs)