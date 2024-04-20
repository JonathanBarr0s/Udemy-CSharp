# Exercício - Pagamentos

Uma empresa possui funcionários próprios e terceirizados. Para cada funcionário, deseja-se registrar nome, horas trabalhadas e valor por hora. Funcionários terceirizados possuem ainda uma despesa adicional.

O pagamento dos funcionários corresponde ao valor da hora multiplicado pelas horas trabalhadas, sendo que os funcionários terceirizados ainda recebem um bônus correspondente a 110% de sua despesa adicional.

Fazer um programa para ler os dados de N funcionários (N fornecido pelo usuário) e armazená-los em uma lista. Depois de ler todos os dados, mostrar nome e pagamento de cada funcionário na mesma ordem em que foram digitados.

Construa o programa conforme projeto abaixo.

<p align="center">
  <img src="https://github.com/JonathanBarr0s/Udemy-CSharp/assets/132490863/7fa8bc2a-19f0-4865-a216-89118ab3615a" width= 30%>
</p>

### Exemplo de Entrada:

```
Enter the number of employees: 3

Employee #1 data:
Outsourced (y/n)? n
Name: Alex
Hours: 50
Value per hour: 20.00

Employee #2 data:
Outsourced (y/n)? y
Name: Bob
Hours: 100
Value per hour: 15.00
Additional charge: 200.00

Employee #3 data:
Outsourced (y/n)? n
Name: Maria
Hours: 60
Value per hour: 20.00
```

### Exemplo de Saída:

```
PAYMENTS:

Alex - $ 1000.00
Bob - $ 1720.00
Maria - $ 1200.00
```

<details>
    <summary><strong>Comportamento Em Memória (Ilustração)</strong></summary>
    <br />
    <div align="left">

<p align="center">
  <img src="https://github.com/JonathanBarr0s/Udemy-CSharp/assets/132490863/470e4811-cb7c-4311-ad1f-a0de86377b4b" width= 50%>
</p>

</details>

---

Minha resposta:

- [Program](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/03.%20Enumera%C3%A7%C3%B5es%20e%20Composi%C3%A7%C3%A3o/00.%20Contratos/Contratos/Contratos/Program.cs)

**Entities**
- [Department](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/03.%20Enumera%C3%A7%C3%B5es%20e%20Composi%C3%A7%C3%A3o/00.%20Contratos/Contratos/Contratos/Entities/Department.cs)
- [HourContract](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/03.%20Enumera%C3%A7%C3%B5es%20e%20Composi%C3%A7%C3%A3o/00.%20Contratos/Contratos/Contratos/Entities/HourContract.cs)
- [Worker](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/03.%20Enumera%C3%A7%C3%B5es%20e%20Composi%C3%A7%C3%A3o/00.%20Contratos/Contratos/Contratos/Entities/Worker.cs)

**Enums**
- [WorkerLevel](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/03.%20Enumera%C3%A7%C3%B5es%20e%20Composi%C3%A7%C3%A3o/00.%20Contratos/Contratos/Contratos/Entities/Enums/WorkerLevel.cs)