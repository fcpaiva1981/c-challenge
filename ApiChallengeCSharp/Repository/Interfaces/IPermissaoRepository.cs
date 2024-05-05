using ApiChallengeCSharp.Model;

namespace ApiChallengeCSharp.Repository.Interfaces;

public interface IPermissaoRepository
{
    Task<List<PermissaoModel>> BuscarTodasPermissoes();
    Task<PermissaoModel> BuscarPorId(int id);
    Task<PermissaoModel> Adicionar(PermissaoModel permissao);
    Task<PermissaoModel> Atualizar(PermissaoModel permissao, int id);
    Task<bool> Apagar(int id);
}
