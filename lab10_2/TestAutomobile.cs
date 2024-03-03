using AutomobileLibrary;
namespace TestAutomobiles;

[TestClass]
public class TestAutomobile
{
    [TestMethod]
    public void TestMethod1()
    {
        Automobile expected = new Automobile();
        Automobile actual = new Automobile();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod2()
    {
        Automobile expected = new Automobile("BMW", 2000, "Черный", 25000, 10, new IdNumber(1));
        Automobile actual = new Automobile("BMW", 2000, "Черный", 25000, 10, new IdNumber(1));
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod3()
    {
        Automobile expected = new Automobile("BMW", 1000, "Черный", -1, -1, new IdNumber(-1));
        Automobile actual = new Automobile("BMW", 2000, "Черный", 0, 0, new IdNumber(0));
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod4()
    {
        Automobile expected = new Automobile();
        expected.RandomInit();
        Automobile actual = expected;
        Assert.IsTrue(true);
    }

    [TestMethod]
    public void TestMethod5()
    {
        Automobile expected = new Automobile("BMW", 2011, "Черный", 10000, 5, new IdNumber(1));
        Automobile actual = new Automobile("Ferrari", 2012, "Черный", 1000, -5, new IdNumber(1));
        int k = expected.CompareTo(actual);
        Assert.AreEqual(k, 0);
    }

    public void TestMethod6()
    {
        Automobile expected = new Automobile();
        expected.RandomInit();
        Automobile actual = (Automobile)expected.Clone();
        Assert.AreEqual(expected, actual);
    }

    public void TestMethod7()
    {
        Automobile expected = new Automobile();
        expected.RandomInit();
        Automobile actual = expected.ShallowCopy();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod8()
    {
        Automobile expected = new Automobile();
        expected.RandomInit();
        Automobile actual = expected;
        Assert.AreEqual(expected.ToString(), actual.ToString());
    }
}
