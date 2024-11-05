using tdd_desafio.Models;
namespace Projeto.Tests;


public class UnitTest1
{
    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TestSomar(int x, int y, int result)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.Somar(x,y);

        Assert.Equal(result, resultadoCalculadora);
    }
    [Theory]
    [InlineData (1, 2, -1)]
    [InlineData (10, 5, 5)]
    public void TestSubtrair(int x, int y, int result){
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.Subtrair(x,y);

        Assert.Equal(result, resultadoCalculadora);
    }
    [Theory]
    [InlineData (3, 2, 6)]
    [InlineData (4, 5, 20)]
    public void TestMultiplicar(int x, int y, int result)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.Multiplicar(x,y);

        Assert.Equal(result, resultadoCalculadora);
    }
    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (45, 5, 9)]
    public void TestDividir(int x, int y, int result)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.Dividir(x,y);

        Assert.Equal(result, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPor0()
    {
        Calculadora calc = new Calculadora();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
    }
    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = new Calculadora();
        calc.Somar(1,2);
        calc.Somar(2,3);
        calc.Somar(5,5);
        calc.Somar(9,2);

       Assert.NotEmpty(calc.Historico());
       Assert.Equal(3, calc.Historico().Count());
    }
}