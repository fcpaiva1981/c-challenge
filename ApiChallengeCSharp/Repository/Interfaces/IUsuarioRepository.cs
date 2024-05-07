using ApiChallengeCSharp.Dto;
using ApiChallengeCSharp.Model;

namespace ApiChallengeCSharp.Repository.Interfaces;

public interface IUsuarioRepository
{
    Task<List<UsuarioModel>> BuscarTodooUsuarios();
    Task<UsuarioModel> BuscarPorId(int id);
    Task<UsuarioModel> Adicionar(UsuarioDto usuario);
    Task<UsuarioModel> Atualizar(UsuarioDto usuario,int id);
    Task<bool> Apagar(int id);
}
