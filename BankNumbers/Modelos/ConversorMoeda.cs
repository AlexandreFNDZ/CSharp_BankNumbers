using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFive
{
    /// <summary>
    /// Receber URL com parametros e retornar os valores de moedas a serem calculados 
    /// </summary>
    public class ConversorMoeda
    {
        /// <summary>
        /// URL recebida pelo construtor
        /// </summary>
        public string URL { get; }

        private readonly string _argumentos;

        /// <summary>
        /// Construtor que recebe uma URL válida e separa os argumentos desejados
        /// </summary>
        /// <param name="url">URL válida contendo os parametros necessários para o cálculo de conversão.</param>
        public ConversorMoeda(string url)
        {
            URL = url;

            int indiceInterrogacao = URL.IndexOf("?");
            _argumentos = URL.Substring(indiceInterrogacao + 1);
        }

        /// <summary>
        /// Recebe o parametro e retorna o valor correspondente
        /// </summary>
        /// <param name="parametro">parametro da URL do qual deseja o valor.</param>
        /// <returns></returns>
        public string GetValor(string parametro)
        {
            string paramCaixaAlta = parametro.ToUpper();
            string argumCaixaAlta = _argumentos.ToUpper();

            string termoBusca = paramCaixaAlta + "=";
            int indiceTermo = argumCaixaAlta.IndexOf(termoBusca);

            string resultado = argumCaixaAlta.Substring(indiceTermo + termoBusca.Length);
            int indiceEComercial = resultado.IndexOf("&");

            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);
        }

    }
}
