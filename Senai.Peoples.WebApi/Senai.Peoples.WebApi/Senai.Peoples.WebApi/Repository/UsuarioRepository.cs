
using Senai.Peoples.WebApi.Domain;
using Senai.Peoples.WebApi.IRepository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string stringConexao = "Data Source=DEV5\\SQLEXPRESS; initial catalog=M_Peoples; user Id=sa; pwd=sa@132";

        public List <UsuarioDomain> ListarUsuarios ()

        {
            List<UsuarioDomain> usuario = new List<UsuarioDomain>

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryListar = "select Email, Senha from Usuario";


            }
        }
    }
}
