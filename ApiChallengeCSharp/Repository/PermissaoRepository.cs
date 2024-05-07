using ApiChallengeCSharp.Data;
using ApiChallengeCSharp.Dto;
using ApiChallengeCSharp.Model;
using ApiChallengeCSharp.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiChallengeCSharp.Repository;

public class PermissaoRepository : IPermissaoRepository
{
    private readonly ChallengeDbContext _dbContext;
    private readonly IUsuarioRepository _usuarioRepository;

    public PermissaoRepository(ChallengeDbContext dbContext, IUsuarioRepository usuarioRepository)
    {
        _dbContext = dbContext;
        _usuarioRepository = usuarioRepository;
    }

    public async Task<PermissaoModel> BuscarPorId(int id)
    {
        return await _dbContext.Permissaos.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<PermissaoModel>> BuscarTodasPermissoes()
    {
        return await _dbContext.Permissaos.ToListAsync();
    }

    public async Task<PermissaoModel> Adicionar(PermissaoDto permissao)
    {
        PermissaoModel permissaoModel = new PermissaoModel();

        permissaoModel.Descricao = permissao.Descricao;
        permissaoModel.UsuarioId =  permissao.UsuarioId;

        await _dbContext.Permissaos.AddAsync(permissaoModel);
        await _dbContext.SaveChangesAsync();
        permissaoModel.Usuario = await _usuarioRepository.BuscarPorId(permissao.UsuarioId);
        return permissaoModel;
    }

    public async Task<PermissaoModel> Atualizar(PermissaoDto permissao, int id)
    {
        PermissaoModel permissaoModel = await BuscarPorId(id);

        permissaoModel.Descricao = permissao.Descricao;
        permissaoModel.UsuarioId = permissao.UsuarioId;

        if (permissaoModel == null)
        {
            throw new Exception($"Usuário para o ID {id} não foi encontrado.");
        }

        permissaoModel.Descricao = permissao.Descricao;
        permissaoModel.UsuarioId = permissao.UsuarioId;

        _dbContext.Update(permissaoModel);
        await _dbContext.SaveChangesAsync();
        permissaoModel.Usuario = await _usuarioRepository.BuscarPorId(permissao.UsuarioId);
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
