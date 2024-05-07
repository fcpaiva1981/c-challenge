using ApiChallengeCSharp.Dto;
using ApiChallengeCSharp.Model;
using ApiChallengeCSharp.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ApiChallengeCSharp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsuariosController : ControllerBase
{
    private readonly IUsuarioRepository _usuarioRepository;

    public UsuariosController(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<UsuarioModel>>> BuscarTodosUsuarios()
    {
        List<UsuarioModel> usuarioModels = await _usuarioRepository.BuscarTodooUsuarios();
        return Ok(usuarioModels);
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<UsuarioModel>> BuscarPorId(int id)
    {
        UsuarioModel usuarioModel = await _usuarioRepository.BuscarPorId(id);
        return Ok(usuarioModel);
    }


    [HttpPost]
    public async Task<ActionResult<UsuarioModel>> Cadastrar([FromBody] UsuarioDto usuario)
    {
        UsuarioModel usuarioModel = await _usuarioRepository.Adicionar(usuario);
        return Ok(usuarioModel);
    }


    [HttpPut("{id}")]
    public async Task<ActionResult<UsuarioModel>> Atualizar(int id, [FromBody] UsuarioDto usuario)
    {
        usuario.Id = id;
        UsuarioModel usuarioModel = await _usuarioRepository.Atualizar(usuario, id);
        return Ok(usuarioModel);
    }


    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(int id)
    {
        bool apagado = await _usuarioRepository.Apagar(id);
        return Ok(apagado);
    }
}