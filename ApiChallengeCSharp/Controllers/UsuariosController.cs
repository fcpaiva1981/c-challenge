using ApiChallengeCSharp.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiChallengeCSharp.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsuariosController : ControllerBase
{
    // GET: api/<UsuariosController>
    [HttpGet]
    public IEnumerable<UsuarioModel> Get()
    {
        List<UsuarioModel> usuarioModels = new List<UsuarioModel>();

        usuarioModels.Add(new UsuarioModel() { Id =1, Nome="Fernando",Email= "fcpaiva1981@gmail.com" });
        return usuarioModels;
    }

    // GET api/<UsuariosController>/5
    [HttpGet("{id}")]
    public UsuarioModel Get(int id)
    {
        UsuarioModel usuarioModel = new UsuarioModel() { Id = 1, Nome = "Fernando", Email = "fcpaiva1981@gmail.com" };
        return usuarioModel;
    }

    // POST api/<UsuariosController>
    [HttpPost]
    public void Post([FromBody] UsuarioModel usuario)
    {
    }

    // PUT api/<UsuariosController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] UsuarioModel usuario)
    {
    }

    // DELETE api/<UsuariosController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
