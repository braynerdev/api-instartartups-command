using Instartups.Domain.Enums;

namespace Instartups.Domain.Entities;

public class PerfilEntity : BaseEntity
{
    public string Slug { get; private set; }
    public TiposPerfisEnum TipoPerfil { get; private set; }
    public string? ImagemPerfilUrl { get; private set; }
    public string? ImagemFundoUrl { get; private set; }
    public long CurtidasTotais { get; private set; }
    public Guid UsuarioId { get; private set; }
    public ReferenciaUsuarioEntity Usuario { get; private set; } = null!;


    private PerfilEntity(TiposPerfisEnum tipoPerfil, string? imagemPerfilUrl, string? imagemFundoUrl, Guid usuarioId, string slug)
    {
        TipoPerfil = tipoPerfil;
        ImagemPerfilUrl = imagemPerfilUrl;
        ImagemFundoUrl = imagemFundoUrl;
        UsuarioId = usuarioId;
        Slug = slug;
    }

    public static PerfilEntity Create(TiposPerfisEnum tipoPerfil, string? imagemPerfilUrl, string? imagemFundoUrl,
        Guid usuarioId, string slug)
    {
        return new PerfilEntity(tipoPerfil, imagemPerfilUrl, imagemFundoUrl, usuarioId, slug);
    }

    public void EditarImagemPerfilUrl(string? imagemPerfilUrl)
    {
        ImagemPerfilUrl = imagemPerfilUrl;
    }

    public void EditarImagemFundoUrl(string? imagemFundoUrl)
    {
        ImagemFundoUrl = imagemFundoUrl;
    }
}
