namespace ShowCase.Tests;

[TestClass]
public class UnitTests
{
    [TestMethod]
    public void CheckTriangle()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        Assert.IsTrue(a > 0.0 && b > 0.0 && c > 0.0
            && a + b > c && b + c > a && c + a > b, "Тест непройден");
    }
}