using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Senai.Peoples.WebApi.IRepository;
using Senai.Peoples.WebApi.Domain;
using System.Data.SqlClient;

namespace Senai.Peoples.WebApi.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {

        private string StringConexao = "Data Source= DEV4\\SQLEXPRESS; initial catalog=M_Peoples; user Id=sa; pwd=sa@132";
        List<FuncionarioDomain> Funcionario = new List<FuncionarioDomain>();

        public List<FuncionarioDomain> Listar()
        {
            

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryListar = "select IdFuncionario, Nome, Sobrenome from Funcionarios";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand (queryListar, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        FuncionarioDomain funcionario = new FuncionarioDomain
                        {
                            IdFuncionario = Convert.ToInt32(rdr[0]),
                            Nome = rdr["Nome"].ToString(),
                            Sobrenome = rdr["Sobrenome"].ToString()
                        };
                        Funcionario.Add(funcionario);
                    }
                } return Funcionario;
            }
        } 

        public void Alterar(FuncionarioDomain funcionario)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryAlterar = "update Funcionarios set Nome = @Nome where IdFuncionario = @IdFuncionario";

                con.Open();

                SqlCommand cmd = new SqlCommand(queryAlterar, con);
                cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@IdFuncionario", funcionario.IdFuncionario);
                cmd.ExecuteNonQuery();
                
            }
        }

        public void Cadastrar(FuncionarioDomain funcionario)
        {
            string queryCadastrar = "insert into Funcionarios (Nome, Sobrenome) values (@Nome, @Sobrenome)";
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                SqlCommand cmd = new SqlCommand(queryCadastrar, con);

                con.Open();

                cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@Sobrenome", funcionario.Sobrenome);
                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        

        public FuncionarioDomain ListarPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
