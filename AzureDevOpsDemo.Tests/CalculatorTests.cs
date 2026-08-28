public class CalculatorTests
{
    [Fact]
    public void Add_ShouldReturnCorrectResult()
    {
        var result = 2 + 3;

        Assert.Equal(5, result);
    }
}