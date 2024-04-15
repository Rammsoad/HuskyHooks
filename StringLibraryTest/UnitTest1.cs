namespace StringLibraryTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TwoPlusTwoEqualsFour()
    {
        var sum = 2+2;
        Assert.AreEqual(sum, 4);
    }
}