﻿using ApiChallengeCSharp.Data;
using ApiChallengeCSharp.Model;
using ApiChallengeCSharp.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiChallengeCSharp.Repository;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly ChallengeDbContext _dbContext;

    public UsuarioRepository(ChallengeDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<UsuarioModel> BuscarPorId(int id)
    {
        return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<UsuarioModel>> BuscarTodooUsuarios()
    {
        return await _dbContext.Usuarios.ToListAsync();
    }

    public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
    {
        _dbContext.Usuarios.Add(usuario);
        await _dbContext.SaveChangesAsync();
        return usuario;
    }

    public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
    {
        UsuarioModel usuarioModel = await BuscarPorId(id);

        if (usuarioModel == null)
        {
            throw new Exception($"Usuário para o ID {id} não foi encontrado.");
        }

        usuarioModel.Nome = usuario.Nome;
        usuarioModel.Email = usuario.Email;

        _dbContext.Update(usuarioModel);
        await _dbContext.SaveChangesAsync();
        return usuarioModel;
    }

    public async Task<bool> Apagar(int id)
    {
        UsuarioModel usuarioModel = await BuscarPorId(id);

        if (usuarioModel == null)
        {
            throw new Exception($"Usuário para o ID {id} não foi encontrado.");
        }

        _dbContext.Usuarios.Remove(usuarioModel);
        await _dbContext.SaveChangesAsync();
        return true;
    }
}
