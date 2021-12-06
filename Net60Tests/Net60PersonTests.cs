using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetStandard20;

namespace Net60Tests;

[TestClass]
public class Net60PersonTests
{
    [TestMethod]
    public void PersonSerializeTest()
    {
        Person person = new() { FirstName = "Jane", LastName = "Doe" };

        string actual = JsonSerializer.Serialize(person, Net60JsonContext.Default.Person);

        string expected = "{\"FirstName\":\"Jane\",\"LastName\":\"Doe\"}";
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PersonDeserializeTest()
    {
        string json = "{\"FirstName\":\"Jane\",\"LastName\":\"Doe\"}";
        Person? person = JsonSerializer.Deserialize(json, Net60JsonContext.Default.Person);

        Assert.IsNotNull(person);
        Assert.AreEqual("Jane", person.FirstName);
        Assert.AreEqual("Doe", person.LastName);
    }
}
