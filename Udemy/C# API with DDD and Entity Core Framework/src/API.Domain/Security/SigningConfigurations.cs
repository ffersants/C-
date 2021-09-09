using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Security
{
    public class SigningConfigurations
    {
        //Esse atributo é do tipo SecurityKey, que é a classe para receber chaves de segurança
        public SecurityKey Key { get; set; }
        //recebe a chave e o algoritmo de assinatura da chave a ser aplicado
        public SigningCredentials SigningCredentials { get; set; }
        public SigningConfigurations()
        {
            //initializes a class with a random key pair of the specified key size.
            using (var provider = new RSACryptoServiceProvider(2048))
            {
                //Cria uma chave assimétrica usando o algoritmo RSA.
                Key = new RsaSecurityKey(provider.ExportParameters(true));
            }
            //chave e algoritmo de assinatura a ser aplicado
            SigningCredentials = new SigningCredentials(Key, SecurityAlgorithms.RsaSha256Signature);
        }
    }
}
