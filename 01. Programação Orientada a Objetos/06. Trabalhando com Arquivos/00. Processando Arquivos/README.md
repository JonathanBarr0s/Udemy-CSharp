# Exercício - Processando Arquivos

Fazer um programa para ler o caminho de um arquivo .csv contendo os dados de itens vendidos. Cada item possui um nome, preço unitário e quantidade, separados por vírgula. Você deve gerar um novo arquivo chamado "summary.csv", localizado em uma subpasta chamada "out" a partir da pasta original do arquivo de origem, contendo apenas o nome e o valor total para aquele item (preço unitário multiplicado pela quantidade), conforme exemplo.

### Exemplo de Entrada:

**Entrada:**

```
TV LED,1290.99,1
Video Game Chair,350.50,3
Iphone X,900.00,2
Samsung Galaxy 9,850.00,2
```

### Exemplo de Saída:

```
TV LED,1290.99
Video Game Chair,1051.50
Iphone X,1800.00
Samsung Galaxy 9,1700.00
```

---

Minha resposta:

- [Program](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/04.%20Heran%C3%A7a%20e%20Polimorfismo/00.%20Pagamentos/Pagamentos/Pagamentos/Program.cs)

**Entities**
- [Reservation](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/05.%20Tratamento%20de%20Exce%C3%A7%C3%B5es/00.%20Reservas/Reservas/Reservas/Entities/Reservation.cs)

**Exceptions**
- [DomainException](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/05.%20Tratamento%20de%20Exce%C3%A7%C3%B5es/00.%20Reservas/Reservas/Reservas/Entities/Exceptions/DomainException.cs)