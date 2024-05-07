using ApiChallengeCSharp.Dto;
using ApiChallengeCSharp.Model;
using ApiChallengeCSharp.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ApiChallengeCSharp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PermissaoController : ControllerBase
{
    private readonly IPermissaoRepository _permissaoRepository;

    public PermissaoController(IPermissaoRepository permissaoRepository)
    {
        _permissaoRepository = permissaoRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PermissaoModel>>> BuscarTodasPermissoes()
    {
        List<PermissaoModel> permissaoModels = await _permissaoRepository.BuscarTodasPermissoes();
        return Ok(permissaoModels);
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<PermissaoModel>> BuscarPorId(int id)
    {
        PermissaoModel permissaoModel = await _permissaoRepository.BuscarPorId(id);
        return Ok(permissaoModel);
    }


    [HttpPost]
    public async Task<ActionResult<PermissaoModel>> Cadastrar([FromBody] PermissaoDto permissao)
    {
        PermissaoModel permissaoModel = await _permissaoRepository.Adicionar(permissao);
        return Ok(permissaoModel);
    }


    [HttpPut("{id}")]
    public async Task<ActionResult<PermissaoModel>> Atualizar(int id, [FromBody] PermissaoDto permissao)
    {
        permissao.Id = id;
        PermissaoModel permissaoModel = await _permissaoRepository.Atualizar(permissao, id);
        return Ok(permissaoModel);
    }


    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(int id)
    {
        bool apagado = await _permissaoRepository.Apagar(id);
        return Ok(apagado);
    }
}