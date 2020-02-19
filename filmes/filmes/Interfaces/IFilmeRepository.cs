using filmes.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmes.Interfaces
{
    interface IFilmeRepository
    {
        List<FilmeDomain> Listar();

        void CadastrarFilme(FilmeDomain filmeDomain);

        void AlterarFilme(FilmeDomain filmeDomain);

        void DeletarFilme(int id);

        FilmeDomain ListarPorId(int id);
    }
}
