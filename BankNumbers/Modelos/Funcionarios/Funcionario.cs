using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo_v2.Funcionarios
{
    /// <summary>
    /// Classe abstrata base para a definição de funcionários.
    /// </summary>
    public abstract class Funcionario 
    {
        /// <summary>
        /// Numero de Funcionários do banco BankNumbers.
        /// </summary>
        public static int TotalDeFuncionarios { get; private set; }

        /// <summary>
        /// Define nome do funcionario.
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Define CPF do funcionario.
        /// </summary>
        public string CPF { get; set; }
        /// <summary>
        /// Define salário do funcionario.
        /// </summary>
        public double Salario { get; protected set; } // Proteger o campo Set do 'Salario' para que não seja acessado por chamadas fora da hierarquia (Classe-mãe e Classes-filha)

        /// <summary>
        /// Cria uma instância de funcionário a partir dos argumentos recebidos.
        /// </summary>
        /// <param name="salario">Salário do Funcionário</param>
        /// <param name="cpf">CPF do funcionário</param>
        public Funcionario(double salario, string cpf) // Construtor 'Funcionario' recebe salario e cpf e atribui às propriedades e acumulador
        {
            Salario = salario;
            CPF = cpf;

            TotalDeFuncionarios++;
        }

        /// <summary>
        /// Método abstrato a ser definido pelas Classes filha.
        /// </summary>
        /// <returns></returns>
        internal protected abstract double GetBonificacao(); // Método abstrato para a que as Classes-filha possam sobrescrever
        /// <summary>
        /// Método abstrato a ser definido pelas Classes filha.
        /// </summary>
        public abstract void AumentarSalario(); // Método abstrato para que as Classes-filha possam sobrescrever
    }
}
