using Exemplo.WebApi.Domains;
using Exemplo.WebApi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo.WebApi.Repository
{

    public class EstudiosRepository : IEstudioRepository
    {
        InLockContext ctx = new InLockContext();

   

        public Estudio BuscarPorId(int id)
        {
            return ctx.Estudio.FirstOrDefault(e => e.IdEstudio == id);
        }

        public void Cadastrar(Estudio novoEstudio)
        {
            ctx.Estudio.Add(novoEstudio);
            // Salva as informações para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            using (InLockContext ctx = new InLockContext())
            {
                Estudio EstudioBuscado = ctx.Estudio.Find(id);
                ctx.Estudio.Remove(EstudioBuscado);
                ctx.SaveChanges();
            }
        }

        public List<Estudio> Listar()
        {
            return ctx.Estudio.ToList();
        }
    }
}
