
namespace StreamingFlix.App;

public class PlanoStreamingService
{
    public string ObterClassificacaoPorQualidade(int telasSimultaneas)
    {
        if (telasSimultaneas == 1)
        {
            return "BÁSICO";
        }

        if (telasSimultaneas == 2)
        {
            return "PADRÃO";
        }

        if (telasSimultaneas >= 4)
        {
            return "PREMIUM";
        }

        throw new ArgumentOutOfRangeException(
            nameof(telasSimultaneas),
            "Quantidade de telas inválida."
        );
    }

    public int CalcularMensalidadeComDesconto(
        int valorBase,
        int mesesContratados)
    {
        if (mesesContratados >= 12)
        {
            return valorBase * 80 / 100;
        }

        if (mesesContratados >= 6)
        {
            return valorBase * 90 / 100;
        }

        return valorBase;
    }

    public bool PodeAcessarConteudoAdulto(
    int idade,
    bool controleParentalAtivo)
{
    return idade >= 18 && !controleParentalAtivo;
}
}
