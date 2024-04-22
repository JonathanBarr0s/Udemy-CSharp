# Exercício - Produtos

Fazer um programa para ler os dados de N produtos (N fornecido pelo usuário). Ao final, mostrar a etiqueta de preço de cada produto na mesma ordem em que foram digitados.

Todo produto possui nome e preço. Produtos importados possuem uma taxa de alfândega, e produtos usados possuem data de fabricação. Estes dados específicos devem ser acrescentados na etiqueta de preço conforme exemplo. Para produtos importados, a taxa e alfândega deve ser acrescentada ao preço final do produto.

Favor implementar o programa conforme projeto abaixo.

<p align="center">
  <img src="https://github.com/JonathanBarr0s/Udemy-CSharp/assets/132490863/70a930ad-04d0-48c8-8487-be08dd5e1873" width= 30%>
</p>

### Exemplo de Entrada:

```
Enter the number of products: 3

Product #1 data:
Common, used or imported (c/u/i)? i
Name: Tablet
Price: 260.00
Customs fee: 20.00

Product #2 data:
Common, used or imported (c/u/i)? c
Name: Notebook
Price: 1100.00

Product #3 data:
Common, used or imported (c/u/i)? u
Name: Iphone
Price: 400.00
Manufacture date (DD/MM/YYYY): 15/03/2017
```

### Exemplo de Saída:

```
PRICE TAGS:

Tablet $ 280.00 (Customs fee: $ 20.00)
Notebook $ 1100.00
Iphone (used) $ 400.00 (Manufacture date: 15/03/2017)
```

---

Minha resposta:

- [Program](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/04.%20Heran%C3%A7a%20e%20Polimorfismo/00.%20Pagamentos/Pagamentos/Pagamentos/Program.cs)

**Entities**
- [Employee](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/04.%20Heran%C3%A7a%20e%20Polimorfismo/00.%20Pagamentos/Pagamentos/Pagamentos/Entities/Employee.cs)
- [OutsourcedEmployee](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/04.%20Heran%C3%A7a%20e%20Polimorfismo/00.%20Pagamentos/Pagamentos/Pagamentos/Entities/OutSourcedEmployee.cs)