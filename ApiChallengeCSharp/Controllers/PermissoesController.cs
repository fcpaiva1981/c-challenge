using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiChallengeCSharp.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PermissoesController : ControllerBase
{
    // GET: api/<PermissoesController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<PermissoesController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<PermissoesController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<PermissoesController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<PermissoesController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
