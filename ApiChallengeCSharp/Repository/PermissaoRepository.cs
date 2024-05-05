using ApiChallengeCSharp.Data;
using ApiChallengeCSharp.Model;
using ApiChallengeCSharp.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiChallengeCSharp.Repository;

public class PermissaoRepository : IPermissaoRepository
{
    private readonly ChallengeDbContext _dbContext;

    public PermissaoRepository(ChallengeDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<PermissaoModel> BuscarPorId(int id)
    {
        return await _dbContext.Permissaos.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<PermissaoModel>> BuscarTodasPermissoes()
    {
        return await _dbContext.Permissaos.ToListAsync();
    }

    public async Task<PermissaoModel> Adicionar(PermissaoModel permissao)
    {
        await _dbContext.Permissaos.AddAsync(permissao);
        await _dbContext.SaveChangesAsync();
        return permissao;
    }

    public async Task<PermissaoModel> Atualizar(PermissaoModel permissao, int id)
    {
        PermissaoModel permissaoModel = await BuscarPorId(id);

        if (permissaoModel == null)
        {
            throw new Exception($"Usuário para o ID {id} não foi encontrado.");
        }

        permissaoModel.Descricao = permissao.Descricao;
        permissaoModel.UsuarioId = permissao.UsuarioId;

        _dbContext.Update(permissaoModel);
        await _dbContext.SaveChangesAsync();
        return permissaoModel;
    }

    public async Task<bool> Apagar(int id)
    {
        PermissaoModel permissaoModel = await BuscarPorId(id);

        if (permissaoModel == null)
        {
            throw new Exception($"Usuário para o ID {id} não foi encontrado.");
        }

        _dbContext.Permissaos.Remove(permissaoModel);
        await _dbContext.SaveChangesAsync();
        return true;
    }

}
