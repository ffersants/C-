using System;
using System.DirectoryServices.Protocols;
using System.Net;

namespace Login_com_credenciais_do_AD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(validateUserByBind("0022985", "sdgfsdafsadf"));
        }
        public static bool validateUserByBind(string username, string password)
        {
            bool result = true;
            var credentials = new NetworkCredential(username, password);
            //serverId recebe o nome do servidor LDAP
            var serverId = new LdapDirectoryIdentifier(new string[] { "alpha.pcdf.gov.br", "aquarius.pcdf.gov.br", "hades.pcdf.gov.br" }, false, false);

            var conn = new LdapConnection(serverId, credentials);
            try
            {
                conn.Bind();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                result = false;
            }

            conn.Dispose();

            return result;
        }
    }
}
