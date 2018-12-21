using BankTwo_v2.Funcionarios;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo_v2
{
    /// <summary>
    /// Parceiro Comercial do banco BankNumbers.
    /// </summary>
    public class ParceiroComercial : IAutenticavel // Segue implementação da Interface 'IAutenticavel'
    {
        AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        /// <summary>
        /// Define uma senha de acesso ao sistema.
        /// </summary>
        public string Senha { get; set; } // Criar propriedade 'Senha' para Parceiros que atendam o requisito de ser Autenticavel

        /// <summary>
        /// Confere se a senha informada é igual a cadastrada para liberar acesso ao sistema.
        /// </summary>
        /// <param name="senha">senha informada para autenticação no sistema.</param>
        /// <returns>True ou False para liberação do acesso ao sistema</returns>
        public bool Autenticar(string senha) // Verificar se senha informada é igual a cadastrada
        {
            return _autenticacaoHelper.CompararSenhas(senha, Senha);            
        }
    }
}
