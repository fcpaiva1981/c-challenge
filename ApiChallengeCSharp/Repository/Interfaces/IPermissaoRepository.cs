using ApiChallengeCSharp.Dto;
using ApiChallengeCSharp.Model;

namespace ApiChallengeCSharp.Repository.Interfaces;

public interface IPermissaoRepository
{
    Task<List<PermissaoModel>> BuscarTodasPermissoes();
    Task<PermissaoModel> BuscarPorId(int id);
    Task<PermissaoModel> Adicionar(PermissaoDto permissao);
    Task<PermissaoModel> Atualizar(PermissaoDto permissao, int id);
    Task<bool> Apagar(int id);
}
