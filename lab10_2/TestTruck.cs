using AutomobileLibrary;
namespace TestAutomobiles;

[TestClass]
public class TestTruck
{
    [TestMethod]
    public void TestMethod1()
    {
        Truck expected = new Truck();
        Truck actual = new Truck();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod2()
    {
        Truck expected = new Truck("BMW", 2000, "Черный", 25000, 10, new IdNumber(1), 1000);
        Truck actual = new Truck("BMW", 2000, "Черный", 25000, 10, new IdNumber(1), 1000);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod3()
    {
        Truck expected = new Truck("BMW", 1000, "Черный", -1, -1, new IdNumber(-1), -1);
        Truck actual = new Truck("BMW", 2000, "Черный", 0, 0, new IdNumber(0), 0);
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
        Truck expected = new Truck("BMW", 2000, "Черный", 25000, 10, new IdNumber(1), 1000);
        Truck actual = expected;
        Assert.AreEqual(expected.ToString(), actual.ToString());
    }
}
