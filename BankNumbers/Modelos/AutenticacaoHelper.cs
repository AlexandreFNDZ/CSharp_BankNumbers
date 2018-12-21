using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    internal class AutenticacaoHelper
    {
        public bool CompararSenhas(string senhaInformada, string senhaCadastrada) // Verificar se senha informada é igual a cadastrada
        {
            return senhaInformada == senhaCadastrada;
        }
    }
}
