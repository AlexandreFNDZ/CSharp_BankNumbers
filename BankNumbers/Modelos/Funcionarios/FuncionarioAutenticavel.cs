using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo_v2.Funcionarios
{
    /// <summary>
    /// Define um funcionário que necessita autenticação.
    /// </summary>
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel // Classe abstrata que herda propriedades e métodos de 'Funcionario' e da Interface 'IAutenticavel'
    {
        AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();

        /// <summary>
        /// Cria uma instância de Funcionário que necessita autenticação.
        /// </summary>
        /// <param name="salario">Salário do funcionario.</param>
        /// <param name="cpf">CPF do funcionario.</param>
        public FuncionarioAutenticavel(double salario, string cpf) // Construtor que recebe salario e cpf e implementa na classe base 'Funcionario'
            : base(salario, cpf)
        {

        }

        /// <summary>
        /// Define a senha do funcionário.
        /// </summary>
        public string Senha { get; set; } // Criar propriedade 'Senha' para Funcionários que atendam o requisito de ser Autenticavel

        /// <summary>
        /// Verifica se a senha informada é igual a senha cadastrada e autoriza a entrada no sistema.
        /// </summary>
        /// <param name="senha">senha informada pelo cliente para autenticação.</param>
        /// <returns>Retorna True ou False para a autenticação.</returns>
        public bool Autenticar(string senha) // Verificar se senha informada é igual a cadastrada
        {
            return _autenticacaoHelper.CompararSenhas(senha, Senha);
        }
    }
}
