using ApiChallengeCSharp.Model;
using Microsoft.AspNetCore.Mvc;

 
namespace ApiChallengeCSharp.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsuariosController : ControllerBase
{
     
    [HttpGet]
    public IEnumerable<UsuarioModel> Get()
    {
        List<UsuarioModel> usuarioModels = new List<UsuarioModel>();

        usuarioModels.Add(new UsuarioModel() { Id =1, Nome="Fernando",Email= "fcpaiva1981@gmail.com" });
        return usuarioModels;
    }

     
    [HttpGet("{id}")]
    public UsuarioModel Get(int id)
    {
        UsuarioModel usuarioModel = new UsuarioModel() { Id = 1, Nome = "Fernando", Email = "fcpaiva1981@gmail.com" };
        return usuarioModel;
    }

   
    [HttpPost]
    public void Post([FromBody] UsuarioModel usuario)
    {
    }

    
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] UsuarioModel usuario)
    {
    }

     
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
