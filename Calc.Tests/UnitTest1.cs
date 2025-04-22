namespace Calc.Tests;

public class Addition
{
    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(0, 1, 1)]
    [InlineData(-10, -10, -20)]
    public void SumsTwoNumber(float a, float b, float expected)
    {
        // Arrange
        var calc = new Math.Calc();

        // Act
        var result = calc.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void HandlesOverflow()
    {
        // Arrange
        var calc = new Math.Calc();
        float a = float.MaxValue;
        float b = float.MaxValue;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => calc.Add(a, b));
    }
}
