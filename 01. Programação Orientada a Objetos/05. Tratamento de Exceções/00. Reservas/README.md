# Exercício - Exceções

Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, data de entrada e data de saída) e mostrar os dados da reserva, inclusive sua duração em dias. Em seguida, ler novas datas de entrada e saída, atualizar a reserva, e mostrar novamente a reserva com os dados atualizados. O programa não deve aceitar dados inválidos para a reserva, conforme as seguintes regras:

- Alterações de reserva só podem ocorrer para datas futuras
- A data de saída deve ser maior que a data de entrada

<p align="center">
  <img src="https://github.com/JonathanBarr0s/Udemy-CSharp/assets/132490863/8622abad-1ce9-4b12-a650-504728a458f2" width= 50%>
</p>

### Exemplo 1:

**Entrada**

```
Room number: 8021
Check-in date (dd/MM/yyyy): 23/09/2019
Check-out date (dd/MM/yyyy): 26/09/2019
```

**Saída**

```
Reservation: Room 8021, check-in: 23/09/2019, check-out: 26/09/2019, 3 nights
```

**Entrada**

```
Enter data to update the reservation:
Check-in date (dd/MM/yyyy): 24/09/2019
Check-out date (dd/MM/yyyy): 29/09/2019
```

**Saída**

```
Reservation: Room 8021, check-in: 24/09/2019, check-out: 29/09/2019, 5 nights
```

---

<br>

### Exemplo 2:

**Entrada**

```
Room number: 8021
Check-in date (dd/MM/yyyy): 23/09/2019
Check-out date (dd/MM/yyyy): 21/09/2019
```

**Saída**

```
Error in reservation: Check-out date must be after check-in date
```

<br>

### Exemplo 3:

**Entrada**

```
Room number: 8021
Check-in date (dd/MM/yyyy): 23/09/2019
Check-out date (dd/MM/yyyy): 26/09/2019
```

**Saída**

```
Reservation: Room 8021, check-in: 23/09/2019, check-out: 26/09/2019, 3 nights
```

**Entrada**

```
Enter data to update the reservation:
Check-in date (dd/MM/yyyy): 24/09/2015
Check-out date (dd/MM/yyyy): 29/09/2015
```

**Saída**

```
Error in reservation: Reservation dates for update must be future dates
```
---
<br>

### Exemplo 4:

**Entrada**

```
Room number: 8021
Check-in date (dd/MM/yyyy): 23/09/2019
Check-out date (dd/MM/yyyy): 26/09/2019
```

**Saída**

```
Reservation: Room 8021, check-in: 23/09/2019, check-out: 26/09/2019, 3 nights
```

**Entrada**

```
Enter data to update the reservation:
Check-in date (dd/MM/yyyy): 24/09/2020
Check-out date (dd/MM/yyyy): 22/09/2020
```

**Saída**

```
Error in reservation: Check-out date must be after check-in date
```

---

Minha resposta:

- [Program](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/04.%20Heran%C3%A7a%20e%20Polimorfismo/00.%20Pagamentos/Pagamentos/Pagamentos/Program.cs)

**Entities**
- [Employee](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/04.%20Heran%C3%A7a%20e%20Polimorfismo/00.%20Pagamentos/Pagamentos/Pagamentos/Entities/Employee.cs)
- [OutsourcedEmployee](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/04.%20Heran%C3%A7a%20e%20Polimorfismo/00.%20Pagamentos/Pagamentos/Pagamentos/Entities/OutSourcedEmployee.cs)