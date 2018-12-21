using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo_v2.Funcionarios
{
    /// <summary>
    /// Define um <see cref="GerenteDeConta"/> no banco BankNumbers.
    /// </summary>
    public class GerenteDeConta : FuncionarioAutenticavel // 'GerenteDeConta' herda propriedades e métodos de 'FuncionarioAutenticavel'
    {
        /// <summary>
        /// Cria uma instância de um funcionário com cargo de <see cref="GerenteDeConta"/>.
        /// </summary>
        /// <param name="cpf">Texto do CPF do funcionáro.</param>
        public GerenteDeConta(string cpf) // Construtor 'GerenteDeConta' recebe cpf e implementa salário e cpf na classe 'Funcionario'
            : base(4000.0, cpf)
        {

        }

        /// <summary>
        /// Calcula a bonificação do <see cref="GerenteDeConta"/>.
        /// </summary>
        /// <returns>Retorna o valor calculado da bonificação.</returns>
        internal protected override double GetBonificacao() // Calcular a bonificação de um diretor (é um método 'override' pois sobrescreve o método da classe-mãe) 
        {
            return Salario * 0.25; 
        }

        /// <summary>
        /// Calcula e define o novo salário do <see cref="GerenteDeConta"/>.
        /// </summary>
        public override void AumentarSalario() // Aumentar salário do diretor
        {
            Salario *= 1.05;
        }
    }
}
