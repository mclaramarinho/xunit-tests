using Calc.Services;

namespace CalcTests;

public class CalcTests
{

    private CalculadoraImpl _calc;

    public CalcTests(){
        _calc = new CalculadoraImpl();
    }

    [Fact]
    public void DeveSomarCorretamente()
    {
        //Arrange
        double num1 = 5;
        double num2 = 10;

        //Act
        double res = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, res);
    }
    [Fact]
    public void DeveSubtrairCorretamente(){
        //Arrange
        double num1 = 10, num2 = 5;

        //Act
        double res = _calc.Subtrair(num1, num2);

        //Assert
        Assert.True(res == 5);
    }

    [Theory]
    [InlineData(new int[] { 2, 6 })]
    public void DeveIndicarPar(int[] numeros){
        Assert.All(numeros, num => Assert.True(_calc.isPar(num)));
    }

    [Theory]
    [InlineData(new int[] { 3, 5 })]
    public void DeveIndicarImpar(int[] numeros){
        Assert.All(numeros, num => Assert.False(_calc.isPar(num)));
    }
}