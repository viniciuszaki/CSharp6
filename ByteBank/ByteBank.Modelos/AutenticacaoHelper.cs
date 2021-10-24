using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    // o modificador internal não permite que a classe seja acessível fora do seu projeto. Ela serve
    // apenas para uso interno no projeto. Se o modificador "internal" não for utilizado na frente
    // e a classe estiver apenas como "class XPTO", assume-se que ela é interna. Exemplo: class Program 
    internal class AutenticacaoHelper
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
