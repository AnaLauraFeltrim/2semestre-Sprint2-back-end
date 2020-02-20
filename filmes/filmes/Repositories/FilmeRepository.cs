using filmes.Domain;
using filmes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace filmes.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private string StringConexao = "Data Source= DEV4\\SQLEXPRESS; initial catalog=Filmes; user Id=sa; pwd=sa@132";

        List<FilmeDomain> Filme = new List<FilmeDomain>();

        public List<FilmeDomain> Listar()
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryListar = "select F.IdFilme, F.Titulo from Filme F ";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryListar, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        FilmeDomain filme = new FilmeDomain
                        {
                            IdFilme = Convert.ToInt32(rdr[0]),
                            Titulo = rdr[1].ToString(),
                            

                            


                        };
                        Filme.Add(filme);
                    }
                }
                return Filme;
            }
        }




        public void AlterarFilme(FilmeDomain filmeDomain)
        {

            string Query = "update Filme set Titulo = @Titulo where IdFilme = @IdFilme";
            using (SqlConnection con = new SqlConnection(StringConexao))
            {

                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Titulo", filmeDomain.Titulo);
                cmd.Parameters.AddWithValue("@IdFilme", filmeDomain.IdFilme);
                cmd.Parameters.AddWithValue("@IdGenero", filmeDomain.IdGenero);
                con.Open();
                cmd.ExecuteNonQuery();


            }

        }

        public void CadastrarFilme(FilmeDomain filmeDomain)
        {
            string Query = "insert into Filme (Titulo) values (@Titulo) ";

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Titulo", filmeDomain.Titulo);
                
                con.Open();
                cmd.ExecuteNonQuery();

            }
        }

        public void DeletarFilme(int id)
        {
            string Query = "delete from Filme where IdFilme = @IdFilme";
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                SqlCommand cmd = new SqlCommand(Query, con);

                cmd.Parameters.AddWithValue("@IdFilme", id);
                con.Open();
                cmd.ExecuteNonQuery();

            }
        }

        public FilmeDomain ListarPorId(int id)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string querySelectById = "select IdFilme, Titulo from Filme where IdFilme = @Id";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectById, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        FilmeDomain filme = new FilmeDomain
                        {
                            IdFilme = Convert.ToInt32(rdr["IdFilme"])

                            ,
                            Titulo = rdr["Titulo"].ToString()
                        };

                        return filme;
                    }

                    return null;
                }
            }
        }
    }

}
