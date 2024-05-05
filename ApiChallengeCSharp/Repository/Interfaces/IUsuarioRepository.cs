﻿using ApiChallengeCSharp.Model;

namespace ApiChallengeCSharp.Repository.Interfaces;

public interface IUsuarioRepository
{
    Task<List<UsuarioModel>> BuscarTodooUsuarios();
    Task<UsuarioModel> BuscarPorId(int id);
    Task<UsuarioModel> Adicionar(UsuarioModel usuario);
    Task<UsuarioModel> Atualizar(UsuarioModel usuario,int id);
    Task<bool> Apagar(int id);
}