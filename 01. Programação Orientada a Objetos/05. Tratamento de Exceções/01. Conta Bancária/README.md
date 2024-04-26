# Exercício - Conta Bancária

Fazer um programa para ler os dados de uma conta bancária e depois realizar um saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de saque da conta. Implemente a conta bancária conforme projeto abaixo:

<p align="center">
  <img src="https://github.com/JonathanBarr0s/Udemy-CSharp/assets/132490863/6ac74585-2d16-4c1b-8276-7cd9442c464a" width= 40%>
</p>

### Cenário 1:

**Entrada:**

```
Enter account data
Number: 8021
Holder: Bob Brown
Initial balance: 500.00
Withdraw limit: 300.00

Enter amount for withdraw: 100.00
```

**Saída:**

```
New balance: 400.00
```

---

<br>

### Cenário 2:

**Entrada:**

```
Enter account data
Number: 8021
Holder: Bob Brown
Initial balance: 500.00
Withdraw limit: 300.00

Enter amount for withdraw: 400.00
```

**Saída:**

```
Withdraw error: The amount exceeds withdraw limit
```

---

<br>

### Cenário 3:

**Entrada:**

```
Enter account data
Number: 8021
Holder: Bob Brown
Initial balance: 500.00
Withdraw limit: 300.00

Enter amount for withdraw: 800.00
```

**Saída:**

```
Withdraw error: The amount exceeds withdraw limit
```

---

<br>

### Cenário 4:

**Entrada:**

```
Enter account data
Number: 8021
Holder: Bob Brown
Initial balance: 200.00
Withdraw limit: 300.00

Enter amount for withdraw: 250.00
```

**Saída:**

```
Withdraw error: Not enough balance
```
---

Minha resposta:

- [Program](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/05.%20Tratamento%20de%20Exce%C3%A7%C3%B5es/01.%20Conta%20Banc%C3%A1ria/ContaBancaria/ContaBancaria/Program.cs)

**Entities**
- [Account](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/05.%20Tratamento%20de%20Exce%C3%A7%C3%B5es/01.%20Conta%20Banc%C3%A1ria/ContaBancaria/ContaBancaria/Entities/Account.cs)

**Exceptions**
- [DomainException](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/05.%20Tratamento%20de%20Exce%C3%A7%C3%B5es/01.%20Conta%20Banc%C3%A1ria/ContaBancaria/ContaBancaria/Entities/Exceptions/DomainException.cs)