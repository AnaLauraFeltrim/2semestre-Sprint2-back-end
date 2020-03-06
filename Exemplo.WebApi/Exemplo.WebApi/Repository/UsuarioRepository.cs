using Exemplo.WebApi.Domains;
using Exemplo.WebApi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo.WebApi.Repository
{
    public class UsuarioRepository : IUusuarioRepository
    {
        InLockContext ctx = new InLockContext();

        public void Atualizar(int id, Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuario.FirstOrDefault(e => e.IdUsuario == id);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuario.Add(novoUsuario);
            // Salva as informações para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            using (InLockContext ctx = new InLockContext())
            {
                Usuario UsuarioBuscado = ctx.Usuario.Find(id);
                ctx.Usuario.Remove(UsuarioBuscado);
                ctx.SaveChanges();
            }
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuario.ToList();
        }
    }
}
