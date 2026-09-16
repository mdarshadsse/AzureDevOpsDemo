public class CalculatorTests
{
    [Fact]
    public void Add_ShouldReturnCorrectResult()
    {
        var result = 2 + 4;

        Assert.Equal(6, result);
    }
}