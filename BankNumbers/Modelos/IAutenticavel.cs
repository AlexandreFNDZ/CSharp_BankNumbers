using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo_v2.Funcionarios
{
    /// <summary>
    /// Interface que obriga a implementação do método <see cref="Autenticar(string)"/> nas classes filha.
    /// </summary>
    public interface IAutenticavel // Interface 'Autenticavel' que dita regra para as classes-filha implementar o método 'Autenticar'
    {
        /// <summary>
        /// Método para autorizar a entrada no sistema.
        /// </summary>
        /// <param name="senha">Senha que será comparada para autorizar a entrada no sistema.</param>
        /// <returns>retorna True ou False.</returns>
        bool Autenticar(string senha); 
    }
}
