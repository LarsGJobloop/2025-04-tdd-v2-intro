namespace Calc.Tests;

public class Addition
{
    [Fact]
    public void SumOneAndOne()
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

    [Fact]
    public void SumTwoAndTwo()
    {
        // Arrange
        var calc = new Math.Calc();
        float a = 2;
        float b = 2;
        float expected = 4;

        // Act
        var result = calc.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}
