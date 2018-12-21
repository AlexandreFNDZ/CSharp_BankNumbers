using _05_Away_Bank;
using BankOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Cria uma Conta Corrente do banco BankNumbers
/// </summary>
public class ContaCorrente
{
    /// <summary>
    /// Numero de saques recusados pelo sistema.
    /// </summary>
    public int ContadorSaquesNaoPermitidos { get; private set; }

    /// <summary>
    /// Numero de transferências recusadas pelo sistema.
    /// </summary>
    public int TransferenciasNaoPermitidas { get; private set; }

    /// <summary>
    /// Numero total de contas criadas no banco BankNumbers.
    /// </summary>
    public static int TotalContasCriadas { get; private set; } // Pode ser consultada, mas não pode ser definida publicamente

    /// <summary>
    /// Valor da taxa cobrada para manutenção das contas (Calculada com base no total de contas criadas).
    /// </summary>
    public static double TaxaOperacao { get; private set; }

    private Cliente _titular; // Campo 'titular' privado e Propriedade 'get' e 'set' atribuída de maneira tradicional
    /// <summary>
    /// Define os dados do cliente cadastrado no banco BankNumbers.
    /// </summary>
    public Cliente Titular
    {
        get
        {
            return _titular;
        }

        set
        {
            _titular = value;
        }
    }

    /// <summary>
    /// Define o numero da agencia, recebida por argumento, da conta do cliente cadastrado no banco BankNumbers.
    /// </summary>
    public int Agencia { get; } // Propriedade 'Agencia' com apenas 'get' (Só pode ser inicializado pelo construtor e, após, se torna somente leitura)

    /// <summary>
    /// Define o numero da conta, recebida por argumento, da conta do cliente cadastrado no banco BankNumbers.
    /// </summary>
    public int Numero { get; } // Propriedade 'Numero' com apenas 'get' (Só pode ser inicializado pelo construtor e, após, se torna somente leitura)

    private double _saldo;
    /// <summary>
    /// Define o saldo da conta do cliente cadastrado no banco BankNumbers.
    /// </summary>
    public double Saldo
    {
        get
        {
            return _saldo; // Devolve o valor do saldo do Cliente
        }

        set
        {
            if (value < 0)
            {
                return; // Valor inválido para o saldo
            }

            _saldo = value; // Atribui o valor recebido para a variavel 'saldo' do Cliente
        }
    }

    /// <summary>
    /// Cria uma instância de ContaCorrente do banco BankNumbers
    /// </summary>
    /// <param name="agencia">Atribui valor para a propriedade <see cref="Agencia"/> e deve ser um número positivo.</param>
    /// <param name="numero">Atribui valor para a propriedade <see cref="Numero"/> e deve ser um número positivo.</param>
    public ContaCorrente(int agencia, int numero) // Construir um tipo 'ContaCorrente' com atributos obrigatórios
    {
        if (agencia <= 0)
        {
            throw new ArgumentException("Agencia inválida", nameof(agencia)); // Verificar e lançar uma exceção caso numero da agencia seja fornecido errado
        }
        if (numero <= 0)
        {
            throw new ArgumentException("Numero da Conta inválida", nameof(numero)); // Verificar e lançar uma exceção caso numero da conta seja fornecido errado
        }

        Agencia = agencia;
        Numero = numero;

        TotalContasCriadas++; // Incrementar o total de Contas Criadas
       
        TaxaOperacao = 30 / TotalContasCriadas; // Determinar a taxa de Operação a partir da quantidade de contas criadas
    }

    /// <summary>
    /// Atualiza o valor do <see cref="Saldo"/> do cliente.
    /// <exception cref="ArgumentException">Exceção lançada quando o valor informado não é um valor positivo (maior que zero).</exception>
    /// <exception cref="SaldoInsuficienteException">Exceção lançada quando o valor informado é maior que o <see cref="Saldo"/> do cliente.</exception>
    /// </summary>
    /// <param name="valor">Valor a ser descontado da conta do cliente. O argumento <paramref name="valor"/> deve ser positivo e maior que o <see cref="Saldo"/> do cliente.</param>
    public void Sacar(double valor)
    {
        if (valor < 0)
        {
            throw new ArgumentException("Valor de saque inválido", nameof(valor)); // Retornar erro se informado valor negativo para saque
        }

        if (this.Saldo < valor)
        {
            ContadorSaquesNaoPermitidos++;
            throw new SaldoInsuficienteException(this.Saldo, valor); // Não possui saldo para realizar ação, retorna false
        } 
        
        this.Saldo -= valor; // Operação saque realizada, subtrai valor do saldo do Cliente   
    }

    /// <summary>
    /// Atualiza o valor do <see cref="Saldo"/> do cliente.
    /// <exception cref="ArgumentException">Exceção lançada quando o valor informado não é um valor positivo (maior que zero).</exception>
    /// </summary>
    /// <param name="valor">Valor a ser acrescentado da conta do cliente. O argumento <paramref name="valor"/> deve ser positivo.</param>
    public void Depositar(double valor)
    {
        if (valor < 0)
        {
            throw new ArgumentException("Valor de saque inválido", nameof(valor)); // Retornar erro se informado valor negativo para saque
        }

        this.Saldo += valor; // Acrescenta valor ao valor existente no saldo do Cliente
    }

    /// <summary>
    /// Transfere o valor do <see cref="Saldo"/> do cliente para a conta de destino da operação.
    /// <exception cref="ArgumentException">Exceção lançada quando o valor informado não é um valor positivo (maior que zero).</exception>
    /// <exception cref="OperacaoFinanceiraException">Exceção lançada quando o valor informado é maior que o <see cref="Saldo"/> do cliente origem.</exception>
    /// </summary>
    /// <param name="valor">Valor a ser descontado da conta de origem e acrescentado da conta de destino. O argumento <paramref name="valor"/> deve ser positivo e maior que o <see cref="Saldo"/> da conta de origem.</param>
    /// <param name="contaDestino">Identificação da Conta que será destinado o valor da operação.</param>
    public void Transferir(double valor, ContaCorrente contaDestino)
    {
        if (valor < 0)
        {
            throw new ArgumentException("Valor para transferência inválido", nameof(valor)); // Retornar erro se informado valor negativo para tranferencia
        }

        try
        {
            this.Sacar(valor);
        }
        catch (SaldoInsuficienteException ex)
        {
            TransferenciasNaoPermitidas++;
            ContadorSaquesNaoPermitidos--;
            throw new OperacaoFinanceiraException("Operação não realizada", ex);
        }
          
        contaDestino.Depositar(valor); // Acrescenta valor ao saldo do Cliente-Destino  
    }

}