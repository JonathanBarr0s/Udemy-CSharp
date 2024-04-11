# Exercício - Pedido de Compra

Ler os dados de um pedido com N itens (N fornecido pelo usuário). Depois, mostrar um sumário do pedido conforme exemplo (próxima página). Nota: o instante do pedido deve ser o instante do sistema: DateTime.Now

<p align="center">
  <img src="https://github.com/JonathanBarr0s/Udemy-CSharp/assets/132490863/11d90941-814d-4d98-98d4-4ed3fead133b" width= 80%>
</p>

Você deverá instanciar os objetos em memória da seguinte forma:

<p align="center">
  <img src="https://github.com/JonathanBarr0s/Udemy-CSharp/assets/132490863/e0493921-50bf-47c1-918b-9c7ab220e99e" width= 70%>
</p>

### Exemplo de Entrada:

```
Enter cliente data:
Name: Alex Green
Email: alex@gmail.com
Birth date (DD/MM/YYYY): 15/03/1985

Enter order data:
Status: Processing
How many items to this order? 2

Enter #1 item data:
Product name: TV
Product price: 1000.00
Quantity: 1

Enter #2 item data:
Product name: Mouse
Product price: 40.00
Quantity: 2
```
### Exemplo de Saída:

```
ORDER SUMMARY:
Order moment: 20/04/2018 11:25:09
Order status: Processing
Client: Alex Green (15/03/1985) - alex@gmail.com

Order items:
TV, $1000.00, Quantity: 1, Subtotal: $1000.00
Mouse, $40.00, Quantity: 2, Subtotal: $80.00
Total price: $1080.00
```
---

Minha resposta:

- [Program](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/03.%20Enumera%C3%A7%C3%B5es%20e%20Composi%C3%A7%C3%A3o/01.%20Post/Post/Post/Program.cs)

**Entities**
- [Post](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/03.%20Enumera%C3%A7%C3%B5es%20e%20Composi%C3%A7%C3%A3o/01.%20Post/Post/Post/Entities/Post.cs)
- [Comment](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/03.%20Enumera%C3%A7%C3%B5es%20e%20Composi%C3%A7%C3%A3o/01.%20Post/Post/Post/Entities/Comment.cs)