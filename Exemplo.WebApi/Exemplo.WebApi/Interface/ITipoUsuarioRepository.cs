﻿using Exemplo.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo.WebApi.Interface
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuario> Listar();

        TipoUsuario BuscarPorId(int id);


        void Cadastrar(TipoUsuario novoTipo);

        void Atualizar(int id, TipoUsuario tipoUsuario);

        void Deletar(int id);
    }
}
