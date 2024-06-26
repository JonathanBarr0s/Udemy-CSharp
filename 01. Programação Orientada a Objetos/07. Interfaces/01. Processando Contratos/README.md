# Exercício - Processando Contratos

Uma empresa deseja automatizar o processamento de seus contratos. O processamento de um contrato consiste em gerar as parcelas a serem pagas para aquele contrato, com base no número de meses desejado.

A empresa utiliza um serviço de pagamento online para realizar o pagamento das parcelas. Os serviços de pagamento online tipicamente cobram um juro mensal, bem como uma taxa por pagamento. Por enquanto, o serviço contratado pela empresa é o do Paypal, que aplica **juros simples** de 1% a cada parcela, mais uma **taxa** de pagamento de 2%.

Fazer um programa para ler os dados de um contrato (número do contrato, data do contrato, e valor total do contrato). Em seguida, o programa deve ler o número de meses para parcelamento do contrato, e daí gerar os registros de parcelas a serem pagas (data e valor), sendo a primeira parcela a ser paga um mês após a data do contrato, a segunda parcela dois meses após o contrato e assim por diante. Mostrar os dados das parcelas na tela.

### Exemplo de Entrada:

```
Enter contract data
Number: 8028
Date (dd/MM/yyyy): 25/06/2018
Contract value: 600.00
Enter number of installments: 3
```

### Exemplo de Saída:

```
Installments:
25/07/2018 - 206.04
25/08/2018 - 208.08
25/09/2018 - 210.12
```

Cálculos (1% de juros simples mensais + 2% de taxa de pagamento):

<table align="center">
    <tr>
        <th align="center">Quota #1: </th>
        <th align="center">Quota #2: </th>
        <th align="center">Quota #3: </th>
    </tr>
    <tr>
        <td align="center">
            200 + 1% * 1 = 202 <br>      
            202 + 2% = 206.04
        </td>
        <td align="center">
           200 + 1% * 2 = 204 <br>
           204 + 2% = 208.08
        </td>
        <td align="center">
            200 + 1% * 3 = 206 <br>
            206 + 2% = 210.12
        </td>
    </tr>
</table>

### Design da camada de domínio

<p align="center">
  <img src="https://github.com/JonathanBarr0s/Udemy-CSharp/assets/132490863/4135e116-f3e9-434f-a302-c1eefd234cd1" width= 50%>
</p>

### Design da camada de serviço

<p align="center">
  <img src="https://github.com/JonathanBarr0s/Udemy-CSharp/assets/132490863/7709dcfc-d432-41dc-9655-1886fac88a97" width= 80%>
</p>

---

Minha resposta:

- [Program](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/07.%20Interfaces/01.%20Processando%20Contratos/ProcessandoContratos/ProcessandoContratos/Program.cs)

**Entities**
- [Contrato](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/07.%20Interfaces/01.%20Processando%20Contratos/ProcessandoContratos/ProcessandoContratos/Entities/Contrato.cs)
- [Prestacao](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/07.%20Interfaces/01.%20Processando%20Contratos/ProcessandoContratos/ProcessandoContratos/Entities/Prestacao.cs)

**Services**
- [IPagamentoOnline](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/07.%20Interfaces/01.%20Processando%20Contratos/ProcessandoContratos/ProcessandoContratos/Services/IPagamentoOnline.cs)
- [Paypal](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/07.%20Interfaces/01.%20Processando%20Contratos/ProcessandoContratos/ProcessandoContratos/Services/Paypal.cs)
- [ServicoContrato](https://github.com/JonathanBarr0s/Udemy-CSharp/blob/main/01.%20Programa%C3%A7%C3%A3o%20Orientada%20a%20Objetos/07.%20Interfaces/01.%20Processando%20Contratos/ProcessandoContratos/ProcessandoContratos/Services/ServicoContrato.cs)

