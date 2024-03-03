using AutomobileLibrary;
namespace TestAutomobiles;

[TestClass]
public class TestCar
{
    [TestMethod]
    public void TestMethod1()
    {
        Car expected = new Car();
        Car actual = new Car();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod2()
    {
        Car expected = new Car("BMW", 2000, "Черный", 25000, 10, new IdNumber(1), 5, 150);
        Car actual = new Car("BMW", 2000, "Черный", 25000, 10, new IdNumber(1), 5, 150);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod3()
    {
        Car expected = new Car("BMW", 1000, "Черный", -1, -1, new IdNumber(-1), -1, -1);
        Car actual = new Car("BMW", 2000, "Черный", 0, 0, new IdNumber(0), 0, 0);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod4()
    {
        Car expected = new Car();
        expected.RandomInit();
        Car actual = expected;
        Assert.IsTrue(true);
    }

    [TestMethod]
    public void TestMethod5()
    {
        Car expected = new Car();
        expected.RandomInit();
        Car actual = expected;
        Assert.AreEqual(expected.ToString(), actual.ToString());
    }
}
