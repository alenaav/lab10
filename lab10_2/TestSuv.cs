using AutomobileLibrary;
namespace TestAutomobiles;

[TestClass]
public class TestSuv
{
    [TestMethod]
    public void TestMethod1()
    {
        Suv expected = new Suv();
        Suv actual = new Suv();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod2()
    {
        Suv expected = new Suv("BMW", 2000, "Черный", 25000, 10, new IdNumber(1), true, "болото");
        Suv actual = new Suv("BMW", 2000, "Черный", 25000, 10, new IdNumber(1), true, "болото");
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod3()
    {
        Suv expected = new Suv("BMW", 1000, "Черный", -1, -1, new IdNumber(-1), true, "болото");
        Suv actual = new Suv("BMW", 2000, "Черный", 0, 0, new IdNumber(0), true, "болото");
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod4()
    {
        Suv expected = new Suv();
        expected.RandomInit();
        Suv actual = expected;
        Assert.IsTrue(true);
    }

    [TestMethod]
    public void TestMethod5()
    {
        Suv expected = new Suv();
        expected.RandomInit();
        Suv actual = expected;
        Assert.AreEqual(expected.ToString(), actual.ToString());
    }
}
