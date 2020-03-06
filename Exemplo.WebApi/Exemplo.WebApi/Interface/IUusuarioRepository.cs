using Exemplo.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo.WebApi.Interface
{
    interface IUusuarioRepository
    {
        List<Usuario> Listar();

        Usuario BuscarPorId(int id);


        void Cadastrar(Usuario novoUsuario);

        void Deletar(int id);
    }
}
