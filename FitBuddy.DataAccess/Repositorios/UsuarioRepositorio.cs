﻿using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.DataAccess.Repositorios
{
    public class UsuarioRepositorio : RepositorioGenérico<Usuario>
    {
        public UsuarioRepositorio(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
