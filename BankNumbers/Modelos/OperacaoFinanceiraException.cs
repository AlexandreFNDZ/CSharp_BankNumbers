using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_Away_Bank
{
    /// <summary>
    /// Exceção de Operações financeiras
    /// </summary>
    public class OperacaoFinanceiraException : Exception
    {
        /// <summary>
        /// Retorna Exceção padrão.
        /// </summary>
        public OperacaoFinanceiraException() // Retornar exception sem argumentos recebidos
        {

        }

        /// <summary>
        /// Retorna Exceção com mensagem personalizada pelo <paramref name="mensagem"/> informado.
        /// </summary>
        /// <param name="mensagem">Texto de erro personalizado apresentado.</param>
        public OperacaoFinanceiraException(string mensagem) // Receber string, e enviar para a classe base uma mensagem de erro
            : base(mensagem)
        {

        }

        /// <summary>
        /// Retorna Exceção com mensagem personalizada pelo <paramref name="mensagem"/> informado e recebe uma Excessão Interna.
        /// </summary>
        /// <param name="mensagem">Texto de erro personalizado apresentado</param>
        /// <param name="excessaoInterna">Exceção interna recebida</param>
        public OperacaoFinanceiraException(string mensagem, Exception excessaoInterna) // Receber string e exception, e enviar para a classe base uma mensagem de erro
            : base(mensagem, excessaoInterna)
        {

        }
    }
}
