using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Net60Tests;

public class Outer
{
    internal class Inner
    {
        public string? Name { get; init; }
    }

    // Uncomment all to see the compiler errors
    //[JsonSerializable(typeof(Inner))]
    //internal partial class InnerJsonContext : JsonSerializerContext
    //{ }

    //public static string InnerTest()
    //{
    //    return JsonSerializer.Serialize(
    //        new Inner() { Name = "name" },
    //        InnerJsonContext.Default.Inner);
    //}

    public static string OuterInnerTest()
    {
        return JsonSerializer.Serialize(
            new Inner() { Name = "name" },
            OuterInnerJsonContext.Default.Inner);
    }
}

[JsonSerializable(typeof(Outer.Inner))]
internal partial class OuterInnerJsonContext : JsonSerializerContext
{ }

[TestClass]
public class OuterInnerTests
{
    //[TestMethod]
    //public void InnerTest()
    //{
    //    Assert.AreEqual("{\"Name\":\"name\"}", Outer.InnerTest());
    //}

    [TestMethod]
    public void OuterInnerTest()
    {
        Assert.AreEqual("{\"Name\":\"name\"}", Outer.OuterInnerTest());
    }
}