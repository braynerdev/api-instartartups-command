namespace Instartups.Domain.Entities;

public class ReferenciaUsuarioEntity
{
    public Guid UserId { get; private set; }
    public string Username { get; private set; }
    public string NomeCompleto { get; private set; }


    private ReferenciaUsuarioEntity(Guid userId, string username, string nomeCompleto)
    {
        UserId = userId;
        Username = username;
        NomeCompleto = nomeCompleto;
    }

    public static ReferenciaUsuarioEntity Criar(Guid userId, string username, string nomeCompleto)
    {
        return new ReferenciaUsuarioEntity(userId, username, nomeCompleto);
    }

    public ReferenciaUsuarioEntity Atualizar(string username)
    {
        Username = username;

        return this;
    }
}
