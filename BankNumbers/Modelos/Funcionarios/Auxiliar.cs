using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo_v2.Funcionarios
{
    /// <summary>
    /// Define um <see cref="Auxiliar"/> no banco BankNumbers.
    /// </summary>
    public class Auxiliar : Funcionario // 'Auxiliar' herda propriedades e métodos de 'Funcionario'
    {
        /// <summary>
        /// Cria uma instância de um funcionário com cargo de <see cref="Auxiliar"/>.
        /// </summary>
        /// <param name="cpf">Texto do CPF do funcionáro.</param>
        public Auxiliar(string cpf) // Construtor 'Auxiliar' recebe cpf e implementa salário e cpf na classe 'Funcionario'
            : base(2000.0, cpf)
        {

        }

        /// <summary>
        /// Calcula a bonificação do <see cref="Auxiliar"/>.
        /// </summary>
        /// <returns>Retorna o valor calculado da bonificação.</returns>
        internal protected override double GetBonificacao() // Calcular a bonificação de um diretor (é um método 'override' pois sobrescreve o método da classe-mãe) 
        {
            return Salario * 0.20; 
        }

        /// <summary>
        /// Calcula e define o novo salário do <see cref="Auxiliar"/>.
        /// </summary>
        public override void AumentarSalario() // Aumentar salário do diretor
        {
            Salario *= 1.10;
        }
    }
}
