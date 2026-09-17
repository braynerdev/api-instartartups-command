namespace Instartups.Domain.Entities.ValueObjects;

public class NomeVO
{
    public string PrimeiroNome { get; }
    public string Sobrenome { get; }
    public string NomeCompleto => $"{PrimeiroNome} {Sobrenome}";

    private NomeVO(string primeiroNome, string sobrenome)
    {
        PrimeiroNome = primeiroNome.ToUpperInvariant();
        Sobrenome = sobrenome.ToUpperInvariant();
    }

    public static NomeVO Create(string primeiroNome, string sobrenome)
    {
        return new NomeVO(primeiroNome, sobrenome);
    }
}
