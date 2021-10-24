using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class ParceiroComercial : IAutenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            // o argumento é a Senha da propriedade e o outro a senha do parametro do método Autenticar
            return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
    }
}