using BankTwo_v2.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo_v2
{
    /// <summary>
    /// Responsável por Registrar Bonificações e retornar o total de Bonificações dos funcionários do banco BankNumbers.
    /// </summary>
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao; // Declara a variável do total de bonificações

        /// <summary>
        /// Acumula o valor da bonificação do funcionário.
        /// </summary>
        /// <param name="funcionario">Funcionário que terá sua bonificação registrada.</param>
        public void Registrar(Funcionario funcionario) // Acumular as bonificações que são registradas
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        /// <summary>
        /// Mostra o total de bonificações concedidas.
        /// </summary>
        /// <returns>Total de Bonificações Registradas</returns>
        public double GetTotalBonificacao() // Retornar o total de bonificações
        {
            return _totalBonificacao;
        }
    }
}
