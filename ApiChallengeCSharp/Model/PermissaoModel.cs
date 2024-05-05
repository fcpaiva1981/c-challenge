namespace ApiChallengeCSharp.Model;

public class PermissaoModel
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public int? UsuarioId { get; set; }
    public virtual UsuarioModel? Usuario { get; set; }
}