﻿using Senai.Peoples.WebApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.IRepository
{
    public class ITipoUsuarioRepository
    {
        List<FuncionarioDomain> ListarUsuario();

        void Cadastrar(FuncionarioDomain funcionario);

        void Alterar(FuncionarioDomain funcionario);

        void Deletar(int id);

        FuncionarioDomain ListarPorId(int id);
    }
}
