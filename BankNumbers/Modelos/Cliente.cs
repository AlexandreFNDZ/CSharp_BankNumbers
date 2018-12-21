using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankOne
{
    /// <summary>
    /// Define um Cliente do banco BankNumbers
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Define o nome do cliente que está sendo cadastrado.
        /// </summary>
        public string Nome { get; set; } // Criado as Propriedades com o atalho 'prop'

        /// <summary>
        /// Define o CPF do cliente que está sendo cadastrado.
        /// </summary>
        public string Cpf { get; set; }

        /// <summary>
        /// Define a profissão do cliente que está sendo cadastrado.
        /// </summary>
        public string Profissao { get; set; }
    }
}
