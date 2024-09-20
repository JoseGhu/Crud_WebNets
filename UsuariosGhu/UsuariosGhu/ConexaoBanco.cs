using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosGhu
{
    static class ConexaoBanco
    {
        private const string servidor = "localhost";  // Ou o IP do servidor MySQL
        private const string bancoDados = "dbUsuarios";
        private const string usuario = "root";
        private const string senha = "12345";

        // Corrigido "servevr" para "Server" e padronizei a string de conexão
        public static string bancoServidor = $"Server={servidor};User Id={usuario};Database={bancoDados};Password={senha};";
    }

}
