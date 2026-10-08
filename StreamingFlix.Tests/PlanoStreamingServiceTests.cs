using StreamingFlix.App;

namespace StreamingFlix.Tests;

public class PlanoStreamingServiceTests
{
    [Theory]
    [InlineData(1, "BÁSICO")]
    [InlineData(2, "PADRÃO")]
    [InlineData(4, "PREMIUM")]
    public void DeveClassificarPlanoCorretamente(
        int telasSimultaneas,
        string classificacaoEsperada)
    {
        // Arrange
        var service = new PlanoStreamingService();

        // Act
        var resultado = service.ObterClassificacaoPorQualidade(telasSimultaneas);

        // Assert
        Assert.Equal(classificacaoEsperada, resultado);
    }

[Theory]
[InlineData(50, 1, 50)]
[InlineData(50, 6, 45)]
[InlineData(50, 12, 40)]
public void DeveCalcularMensalidadeComDescontoCorretamente(
    int valorBase,
    int mesesContratados,
    int valorEsperado)
{
    // Arrange
    var service = new PlanoStreamingService();

    // Act
    var resultado = service.CalcularMensalidadeComDesconto(
        valorBase,
        mesesContratados);

    // Assert
    Assert.Equal(valorEsperado, resultado);
}

[Theory]
[InlineData(20, false, true)]
[InlineData(20, true, false)]
[InlineData(16, false, false)]
public void DeveValidarAcessoAoConteudoAdultoCorretamente(
    int idade,
    bool controleParentalAtivo,
    bool acessoEsperado)
{
    // Arrange
    var service = new PlanoStreamingService();

    // Act
    var resultado = service.PodeAcessarConteudoAdulto(
        idade,
        controleParentalAtivo);

    // Assert
    Assert.Equal(acessoEsperado, resultado);
    }

}