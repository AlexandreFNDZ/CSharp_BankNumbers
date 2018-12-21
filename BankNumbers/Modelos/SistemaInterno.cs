using BankTwo_v2.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo_v2
{
    class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha) // Conferir se a senha fornecida é igual a cadastrada. Método retorna 'true' ou 'false' para a chamada de 'Logar'
        {
            bool userAutenticado = funcionario.Autenticar(senha);

            if (userAutenticado)
            {
                Console.WriteLine("Bem vindo ao Sistema!"); // Aceitar Login
                return true;
            }
            else
            {
                Console.WriteLine("Usuario e/ou senha incorreta"); // Recusar Login
                return false;
            }
        }
    }
}
