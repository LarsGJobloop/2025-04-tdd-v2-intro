namespace Calc.Tests;

public class Addition
{
    [Fact]
    public void SumsTwoIntegers()
    {
        // Arrange
        var calc = new Math.Calc();
        float a = 1;
        float b = 1;
        float expected = 2;

        // Act
        var result = calc.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}
