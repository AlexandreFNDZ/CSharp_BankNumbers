using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_Away_Bank
{
    /// <summary>
    /// Exceção de Saldo Insuficiente para realizar operações financeiras.
    /// </summary>
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        /// <summary>
        /// Define o valor disponível na conta do cliente BankNumbers.
        /// </summary>
        public double Saldo { get; }

        /// <summary>
        /// Define o valor a ser retirado da conta do cliente BankNumbers.
        /// </summary>
        public double ValorSaque { get; }

        /// <summary>
        /// Retorna Exceção padrão.
        /// </summary>
        public SaldoInsuficienteException() // Retornar exception sem argumentos recebidos
        {

        }

        /// <summary>
        /// Retorna Exceção com mensagem personalizada pelo <paramref name="mensagem"/> informado.
        /// </summary>
        /// <param name="mensagem">Texto de erro personalizado apresentado.</param>
        public SaldoInsuficienteException(string mensagem) // Receber string, e enviar para a classe base uma mensagem de erro
            : base(mensagem)
        {

        }

        /// <summary>
        /// Retorna Exceção com mensagem personalizada pelo <paramref name="mensagem"/> informado e recebe uma Excessão Interna.
        /// </summary>
        /// <param name="mensagem">Texto de erro personalizado apresentado</param>
        /// <param name="excessaoInterna">Exceção interna recebida</param>
        public SaldoInsuficienteException(string mensagem, Exception excessaoInterna) // Receber string e exception, e enviar para a classe base uma mensagem de erro
            : base(mensagem, excessaoInterna)
        {

        }

        /// <summary>
        /// Retorna Exceção com mensagem detalhada dos valores que tentaram ser alterados.
        /// </summary>
        /// <param name="saldo">Valor do saldo da conta do cliente.</param>
        /// <param name="valorSaque">Valor do saque a ser realizado.</param>
        public SaldoInsuficienteException(double saldo, double valorSaque) // Receber valores de saldo e saque, e enviar para a classe base uma mensagem de erro
            : this("Tentativa de Saque no valor de R$" + valorSaque + " inválida. Saldo Disponível: R$" + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
    }
}
